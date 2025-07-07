using BarcodeStandard;
using PaseDeABordar.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using BarcodeLib;
using System.Windows.Forms;


namespace PaseDeABordar
{
    public partial class frmChekar : Form
    {
        #region variables
        //Instancia de la clase de acceso a datos para obtener información de la base de datos
        clsDaoDBAeropuerto daoDatos = new clsDaoDBAeropuerto();
        //guarda el número de boleto ingresado o escaneado
        private string numeroBoleto;
        #endregion

        #region Eventos del formulario
        public frmChekar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento Load del formulario de check-in, inicializando los controles y la interfaz.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento (el formulario)</param>
        /// <param name="e">Argumentos del evento</param>
        /// <remarks>
        /// Este método realiza las siguientes configuraciones iniciales:
        /// 1. Deshabilita los campos de texto para nombre y asiento (solo lectura)
        /// 2. Configura el ListView para mostrar detalles de pasajeros faltantes:
        ///    - Agrega columnas para Nombre (150px), Destino (120px) y Es Menor (80px)
        /// 3. Actualiza la lista de pasajeros faltantes llamando al método correspondiente
        /// 
        /// Notas importantes:
        /// - Los campos txtNombre y txtAsiento se deshabilitan para evitar edición directa
        /// - El ListView se configura con un estilo de vista detallada (similar a un grid)
        /// - La actualización inicial carga los datos actuales de pasajeros pendientes
        /// </remarks>
        private void frmChekar_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtAsiento.Enabled = false;


            lisviewPasagerosFaltantes.View = View.Details;
            lisviewPasagerosFaltantes.Columns.Add("Nombre", 150);
            lisviewPasagerosFaltantes.Columns.Add("Destino", 120);
            lisviewPasagerosFaltantes.Columns.Add("Es Menor", 80);

            ActualizarListaPasajerosFaltantes();
        }

        #endregion

        #region metodos auxiliares
        /// <summary>
        /// Genera e imprime una tarjeta de embarque con diseño de un pase de abordar, incluyendo información del pasajero,
        /// detalles del vuelo, código de barras y diseño visual profesional con secciones diferenciadas.
        /// </summary>
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            var datos = daoDatos.ObtenerDatosPasajero(numeroBoleto);
            if (datos == null)
            {
                MessageBox.Show("No se encontraron datos para el número de boleto proporcionado.");
                return;
            }

            Graphics g = e.Graphics;
            Font fontTituloGrande = new Font("Arial", 24, FontStyle.Bold);
            Font fontTitulo = new Font("Arial", 20, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 12);
            Font fontDatos = new Font("Arial", 12, FontStyle.Bold);
            Font fontDestino = new Font("Arial", 22, FontStyle.Bold);
            Font fontRuta = new Font("Arial", 16, FontStyle.Bold);

            int pageWidth = e.PageBounds.Width;
            int leftMargin = 60;
            int rightSection = (int)(pageWidth * 0.55);
            int currentY = 50;
            int lineSpacing = 35;
            int cornerRadius = 15;
            int framePadding = 20;
            int frameX = leftMargin - framePadding;
            int frameY = currentY - framePadding;
            int frameWidth = pageWidth - 2 * frameX;
            int headerHeight = 80;
            int dividerX = rightSection - 20;


            currentY = frameY + headerHeight + 20;

            // ==== Sección izquierda ====
            int leftContentBottom = currentY;
            g.DrawString("NAME: " + datos.Pasajero.Nombre.ToUpper(), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            g.DrawString(datos.Pasajero.Apellido.ToUpper(), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing*2;

            g.DrawString("FLIGHT " + datos.Vuelo.NumeroVuelo, fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            g.DrawString("SEAT " + datos.NumeroAsiento.ToUpper(), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            g.DrawString("TIME " + datos.Vuelo.FechaHoraSalida.ToString("HH:mm"), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing + 15;

            g.DrawString("SEAT " + datos.NumeroAsiento.ToUpper(), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            g.DrawString("TIME " + datos.Vuelo.FechaHoraSalida.ToString("HH:mm"), fontDatos, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing + 15;

            string origen = datos.Pasajero.Origen.Contains("(") ? datos.Pasajero.Origen.Split('(')[0].Trim() : datos.Pasajero.Origen;
            string destino = datos.Pasajero.Destino.Contains("(") ? datos.Pasajero.Destino.Split('(')[0].Trim() : datos.Pasajero.Destino;

            // FROM y TO en dos líneas
            g.DrawString("FROM " + origen.ToUpper(), fontRuta, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            g.DrawString("TO " + destino.ToUpper(), fontRuta, Brushes.Black, leftMargin, currentY);
            currentY += lineSpacing;

            leftContentBottom = currentY;

            // ==== Sección derecha ====
            currentY = frameY + headerHeight + 20;
            int rightContentBottom = currentY;

            g.DrawString("BOARDING PASS", fontTitulo, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing + 25;

            g.DrawString("FLIGHT " + datos.Vuelo.NumeroVuelo.PadLeft(7, '0'), fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing;

            g.DrawString("SEAT " + datos.NumeroAsiento.ToUpper(), fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing;

            g.DrawString("FROM " + origen.ToUpper(), fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing;

            g.DrawString("TO " + destino.ToUpper(), fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing * 3;

            // Puerta de embarque (estática)
            g.DrawString("GATE B4", fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing;

            g.DrawString("TIME " + datos.Vuelo.FechaHoraSalida.ToString("HH:mm"), fontDatos, Brushes.Black, rightSection, currentY);
            currentY += lineSpacing;

           

            if (datos.Pasajero.EsMenor)
            {
                g.DrawString("(MENOR DE EDAD)", fontDatos, Brushes.Black, leftMargin, currentY);
                currentY += lineSpacing;
            }

            leftContentBottom = currentY;

            // ==== Código de barras ====
            Barcode codigoBarras = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                BarWidth = 1
            };

            // Reduce el ancho para que no se salga
            Image imgBarcode = codigoBarras.Encode(TYPE.CODE128, datos.NumeroBoleto, Color.Black, Color.White, 180, 70);

            int barcodeX = rightSection; // centrado más a la izquierda
            int barcodeY = currentY + 20;
            g.DrawImage(imgBarcode, barcodeX, barcodeY);
            rightContentBottom = barcodeY + 80;

            // ==== Marco principal ====
            int frameHeight = rightContentBottom - frameY + 20;
            GraphicsPath framePath = new GraphicsPath();
            framePath.AddArc(frameX, frameY, cornerRadius, cornerRadius, 180, 90);
            framePath.AddArc(frameX + frameWidth - cornerRadius, frameY, cornerRadius, cornerRadius, 270, 90);
            framePath.AddArc(frameX + frameWidth - cornerRadius, frameY + frameHeight - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            framePath.AddArc(frameX, frameY + frameHeight - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            framePath.CloseFigure();
            g.DrawPath(new Pen(Color.Black, 2), framePath);

            // ==== Encabezado izquierdo ====
            int leftHeaderWidth = dividerX - frameX;
            GraphicsPath leftHeaderPath = new GraphicsPath();
            leftHeaderPath.AddArc(frameX, frameY, cornerRadius, cornerRadius, 180, 90);
            leftHeaderPath.AddLine(frameX + cornerRadius, frameY, frameX + leftHeaderWidth, frameY);
            leftHeaderPath.AddLine(frameX + leftHeaderWidth, frameY, frameX + leftHeaderWidth, frameY + headerHeight);
            leftHeaderPath.AddLine(frameX + leftHeaderWidth, frameY + headerHeight, frameX, frameY + headerHeight);
            leftHeaderPath.CloseFigure();

            using (Brush blueBrush = new LinearGradientBrush(new Rectangle(frameX, frameY, leftHeaderWidth, headerHeight),
                                                         Color.DarkMagenta, Color.Black, LinearGradientMode.Vertical))
            {
                g.FillPath(blueBrush, leftHeaderPath);
            }

            g.DrawString("EXECUTIVE CLASS", new Font("Arial", 16, FontStyle.Bold), Brushes.White,
                        leftMargin, frameY + 15);
            g.DrawString("BOARDING PASS", new Font("Arial", 24, FontStyle.Bold), Brushes.White,
                        leftMargin, frameY + 40);

            // ==== Encabezado derecho ====
            int rightHeaderX = dividerX;
            int rightHeaderWidth = frameX + frameWidth - rightHeaderX;
            GraphicsPath rightHeaderPath = new GraphicsPath();
            rightHeaderPath.AddLine(rightHeaderX, frameY, rightHeaderX + rightHeaderWidth - cornerRadius, frameY);
            rightHeaderPath.AddArc(rightHeaderX + rightHeaderWidth - cornerRadius, frameY, cornerRadius, cornerRadius, 270, 90);
            rightHeaderPath.AddLine(rightHeaderX + rightHeaderWidth, frameY + cornerRadius, rightHeaderX + rightHeaderWidth, frameY + headerHeight);
            rightHeaderPath.AddLine(rightHeaderX + rightHeaderWidth, frameY + headerHeight, rightHeaderX, frameY + headerHeight);
            rightHeaderPath.CloseFigure();

            using (Brush darkBlueBrush = new LinearGradientBrush(new Rectangle(rightHeaderX, frameY, rightHeaderWidth, headerHeight),
                                                             Color.Black, Color.Black, LinearGradientMode.Vertical))
            {
                g.FillPath(darkBlueBrush, rightHeaderPath);
            }

            g.DrawString("EXECUTIVE CLASS", new Font("Arial", 16, FontStyle.Bold), Brushes.White,
                        rightSection, frameY + 15);
            g.DrawString("BOARDING PASS", new Font("Arial", 24, FontStyle.Bold), Brushes.White,
                        rightSection, frameY + 40);

            // ==== Línea divisoria ====
            Pen solidPen = new Pen(Color.Black, 1.5f);
            g.DrawLine(solidPen, dividerX, frameY, dividerX, frameY + frameHeight);
        }

        /// <summary>
        /// Actualiza la lista de pasajeros faltantes mostrando nombre, destino y condición de menor edad,
        /// obteniendo los datos de pasajeros que no han realizado check-in.
        private void ActualizarListaPasajerosFaltantes()
        {
            lisviewPasagerosFaltantes.Items.Clear();

            var faltantes = daoDatos.ObtenerPasajerosSinCheckIn();

            foreach (var pasajero in faltantes)
            {
                ListViewItem item = new ListViewItem(pasajero.Nombre + " " + pasajero.Apellido);
                item.SubItems.Add(pasajero.Destino);
                item.SubItems.Add(pasajero.EsMenor ? "Sí" : "No");
                lisviewPasagerosFaltantes.Items.Add(item);
            }
        }
        #endregion

        #region Eventos de los controles
        /// <summary>
        /// Actualiza la información del pasajero cuando se modifica el texto del campo de clave,
        /// mostrando nombre y asiento si se encuentra el boleto o limpiando los campos si no existe.
        /// </summary>
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            numeroBoleto = txtClave.Text.Trim(); // Guarda para que ImprimirPagina lo use
            var datos = daoDatos.ObtenerDatosPasajero(numeroBoleto);

            if (datos != null)
            {
                txtNombre.Text = datos.Pasajero.NombreCompleto;
                txtAsiento.Text = datos.NumeroAsiento;
            }
            else
            {
                txtNombre.Text = "";
                txtAsiento.Text = "";
            }
        }

        /// <summary>
        /// Maneja la selección de pasajeros en la lista de faltantes, actualizando los campos de nombre y asiento
        /// con la información del pasajero seleccionado.
        /// </summary>
        private void lisviewPasagerosFaltantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos de los botones
        /// <summary>
        /// Realiza el proceso de check-in para el boleto actual, validando primero que exista un número de boleto,
        /// actualiza el estado en la base de datos y refresca la lista de pasajeros faltantes.
        /// </summary>
        /// <remarks>
        /// Este método:
        /// 1. Valida que el número de boleto no esté vacío
        /// 2. Marca el check-in como realizado en la base de datos
        /// 3. Muestra confirmación al usuario
        /// 4. Actualiza la lista de pasajeros pendientes
        /// 
        /// Efectos:
        /// - Muestra MessageBox de error si no hay boleto seleccionado
        /// - Actualiza el estado del boleto en la base de datos
        /// - Refresca la interfaz mediante ActualizarListaPasajerosFaltantes()
        /// </remarks>
        private void btnCheckInRealizado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeroBoleto))
            {
                MessageBox.Show("Primero escanea o ingresa un boleto válido.");
                return;
            }

            daoDatos.MarcarCheckInRealizado(numeroBoleto);
            MessageBox.Show("Check-in realizado correctamente.");

            ActualizarListaPasajerosFaltantes();
        }

        /// <summary>
        /// Maneja la impresión del pase de abordar, validando y mostrando los datos del pasajero antes de generar
        /// el documento de impresión con el formato establecido.
        /// </summary>
        /// <remarks>
        /// Flujo de operación:
        /// 1. Obtiene y valida el número de boleto del campo de texto
        /// 2. Recupera los datos del pasajero desde la base de datos
        /// 3. Actualiza los campos de nombre y asiento en la interfaz
        /// 4. Configura e inicia el proceso de impresión del boarding pass
        ///
        /// Comportamientos:
        /// - Muestra advertencia si no encuentra datos del boleto
        /// - Actualiza la UI con los datos del pasajero
        /// - Genera documento de impresión con el formato definido en ImprimirPagina
        /// - Maneja todo el flujo de impresión automáticamente
        /// </remarks>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            numeroBoleto = txtClave.Text.Trim();
            var datos = daoDatos.ObtenerDatosPasajero(numeroBoleto);

            if (datos == null)
            {
                MessageBox.Show("No se encontraron datos para el boleto.");
                return;
            }

            txtNombre.Text = datos.Pasajero.NombreCompleto;
            txtAsiento.Text = datos.NumeroAsiento;

            // Llamar al PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += ImprimirPagina;
            pd.Print();
        }
        #endregion
    }

}
