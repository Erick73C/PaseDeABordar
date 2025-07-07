using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseDeABordar.DB
{
    /// <summary>
    /// Con esta clase se define la estructura de un pasajero.
    /// </summary>
    public class Pasajero
    {
        public string NumeroPasajero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
        public string Telefono { get; set; }
        public string Asiento { get; set; }
        public decimal PrecioBase { get; set; }
        public int NumeroMaletas { get; set; }
        public string NumeroPasaporte { get; set; }
        public decimal PrecioMaletas { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        //public double PrecioBaseVuelo { get; set; }
        public bool EsMenor { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioTotal => PrecioBase + PrecioMaletas;
        public string Descripcion => EsMenor ? $"{Nombre} {Apellido} (Menor)" : $"{Nombre} {Apellido}";
        public decimal TotalConDescuento => PrecioBase + PrecioMaletas - Descuento;
        //+ PrecioBaseVuelo;
    }
}
