using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseDeABordar.DB
{
    public class clsDaoDBAeropuerto
    {
        //Se define la cadena de conexión a la base de datos

        private readonly string conexion =
           //Poner los datos de la conexión a la base de datos
           //IMPORTANTE: Cambiar la cadena de conexión según tu configuración de base de datos
           //La base de datos se llama "DBAeropuerto" 
           "server = localhost;  database = dbaeropuerto; uid = root; pwd = ;";

        #region metodos de la clase clsDaoDBAeropuerto
        /// <summary>
        /// Obtiene todos los datos asociados a un boleto específico incluyendo información detallada del pasajero,
        /// vuelo y estado del boleto, realizando una consulta JOIN entre las tablas de boletos, pasajeros y vuelos.
        /// </summary>
        /// <param name="numeroBoleto">Número único del boleto a consultar</param>
        /// <returns>
        /// Objeto <see cref="Boleto"/> completo con toda la información relacionada si se encuentra,
        /// o null si no existe el boleto especificado.
        /// </returns>
        /// <exception cref="ApplicationException">
        /// Se lanza cuando ocurre un error durante la consulta a la base de datos,
        /// conteniendo la excepción original como InnerException.
        /// </exception>
        /// <remarks>
        /// La consulta recupera y combina datos de:
        /// - Información básica del boleto (asiento, estado de check-in, maletas)
        /// - Datos personales del pasajero (nombre, pasaporte, contacto)
        /// - Detalles completos del vuelo (origen, destino, fechas, precios)
        /// </remarks>
        public Boleto ObtenerDatosPasajero(string numeroBoleto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"SELECT 
                            b.NumeroBoleto, b.NumeroAsiento, b.TieneMaleta, b.CheckInRealizado, b.HaAbordado,
                            p.NumeroPasajero, p.Nombre, p.Apellido, p.Telefono, p.Asiento AS AsientoPasajero,
                            p.PrecioBase, p.NumeroMaletas, p.NumeroPasaporte, p.PrecioMaletas,
                            p.Origen, p.Destino, p.EsMenor, p.Descuento,
                            v.NumeroVuelo, v.AeropuertoOrigen, v.AeropuertoDestino, v.FechaHoraSalida, v.FechaHoraLlegada, v.PrecioBase AS PrecioVuelo
                        FROM boletos b
                        JOIN pasajeros p ON b.NumeroPasajero = p.NumeroPasajero
                        JOIN vuelos v ON b.NumeroVuelo = v.NumeroVuelo
                        WHERE b.NumeroBoleto = @NumeroBoleto";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroBoleto", numeroBoleto);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var pasajero = new Pasajero
                    {
                        NumeroPasajero = reader["NumeroPasajero"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Asiento = reader["AsientoPasajero"].ToString(),
                        PrecioBase = Convert.ToDecimal(reader["PrecioBase"]),
                        NumeroMaletas = Convert.ToInt32(reader["NumeroMaletas"]),
                        NumeroPasaporte = reader["NumeroPasaporte"].ToString(),
                        PrecioMaletas = Convert.ToDecimal(reader["PrecioMaletas"]),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        EsMenor = Convert.ToBoolean(reader["EsMenor"]),
                        Descuento = Convert.ToDecimal(reader["Descuento"])
                    };

                    var vuelo = new Vuelo
                    {
                        NumeroVuelo = reader["NumeroVuelo"].ToString(),
                        AeropuertoOrigen = reader["AeropuertoOrigen"].ToString(),
                        AeropuertoDestino = reader["AeropuertoDestino"].ToString(),
                        FechaHoraSalida = Convert.ToDateTime(reader["FechaHoraSalida"]),
                        FechaHoraLlegada = Convert.ToDateTime(reader["FechaHoraLlegada"]),
                        PrecioBase = Convert.ToDecimal(reader["PrecioVuelo"])
                    };

                    var boleto = new Boleto
                    {
                        NumeroBoleto = reader["NumeroBoleto"].ToString(),
                        NumeroAsiento = reader["NumeroAsiento"].ToString(),
                        TieneMaleta = Convert.ToBoolean(reader["TieneMaleta"]),
                        CheckInRealizado = Convert.ToBoolean(reader["CheckInRealizado"]),
                        HaAbordado = Convert.ToBoolean(reader["HaAbordado"]),
                        Pasajero = pasajero,
                        Vuelo = vuelo
                    };

                    return boleto;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los datos del pasajero por número de boleto.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene una lista de pasajeros que no han realizado check-in, incluyendo sus datos básicos.
        /// </summary>
        /// <returns>
        /// Lista de objetos <see cref="Pasajero"/> con nombre, apellido, destino y condición de menor edad,
        /// o lista vacía si no hay pasajeros pendientes de check-in.
        /// </returns>
        /// <exception cref="ApplicationException">
        /// Se lanza cuando ocurre un error al acceder a la base de datos,
        /// conteniendo la excepción original como InnerException.
        /// </exception>
        /// <remarks>
        /// Realiza una consulta JOIN entre las tablas de boletos y pasajeros,
        /// filtrando por boletos con CheckInRealizado = false (0).
        /// Solo incluye los campos esenciales para identificar a los pasajeros faltantes.
        /// </remarks>
        public List<Pasajero> ObtenerPasajerosSinCheckIn()
        {
            List<Pasajero> lista = new List<Pasajero>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"SELECT p.Nombre, p.Apellido, p.Destino, p.EsMenor
                         FROM boletos b
                         JOIN pasajeros p ON b.NumeroPasajero = p.NumeroPasajero
                         WHERE b.CheckInRealizado = 0";

                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var pasajero = new Pasajero
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        EsMenor = Convert.ToBoolean(reader["EsMenor"])
                    };
                    lista.Add(pasajero);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener pasajeros sin check-in.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }


        /// <summary>
        /// Marca el check-in como realizado para un boleto específico en la base de datos.
        /// Actualiza el campo <c>CheckInRealizado</c> a <c>1</c> (true) en la tabla <c>boletos</c>
        /// para el número de boleto proporcionado.
        /// </summary>
        /// <param name="numeroBoleto">Número único del boleto al que se le marcará el check-in.</param>
        /// <returns>
        /// No retorna ningún valor. Si ocurre un error durante la actualización, lanza una <see cref="ApplicationException"/>
        /// con el mensaje correspondiente.
        /// </returns>
        /// /// <remarks>
        /// Este método:
        /// - Establece CheckInRealizado = 1 (true) para el boleto especificado
        /// - No retorna valor pero puede lanzar excepción en caso de error
        /// - Maneja adecuadamente los recursos de conexión a la base de datos
        /// - Es utilizado típicamente en el proceso de registro de pasajeros
        /// </remarks>
        public void MarcarCheckInRealizado(string numeroBoleto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "UPDATE boletos SET CheckInRealizado = 1 WHERE NumeroBoleto = @NumeroBoleto";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroBoleto", numeroBoleto);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al marcar el check-in.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }
        #endregion

    }
}
