using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Text;
using Controladores;
using Modelos;
using System.Net.WebSockets;

namespace Vista
{
    public partial class GenerarTicket : Form
    {
        private TrabajoController _trabajoController;
        private TareaController _tareaController;
        private int _trabajoId;
        public GenerarTicket(int trabajoID)
        {
            InitializeComponent();
            _trabajoController = new TrabajoController();
            _tareaController = new TareaController();
            _trabajoId = trabajoID;
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            var ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            var trabajo = _trabajoController.GetOne(_trabajoId);
            var tareas = _tareaController.GetTareasDelTrabajoList(_trabajoId);

            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 1000;
            int y = 20;
            int x = 20;
            float montoTrabajo = 0;

            e.Graphics.DrawString("Cliente: " + trabajo.Cliente.Nombre, font, Brushes.Black, new RectangleF(x, y += 20, width, 20));
            e.Graphics.DrawString("Dispositivo: " + trabajo.NombreDispositivo, font, Brushes.Black, new RectangleF(x, y += 20, width, 20));

            string problema = "Problema: " + trabajo.DescripcionProblema;
            int maxChars = 85;
            int linea = 0;

            while (problema.Length > 0)
            {
                int take = Math.Min(maxChars, problema.Length);
                string parte = problema.Substring(0, take);
                problema = problema.Substring(take);

                e.Graphics.DrawString(parte, font, Brushes.Black, new RectangleF(x, y += 20, width, 20));
                linea++;
            }

            //esta linea es para separar los montos de los datos del cliente
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += 20, width, 20));

            foreach (var tarea in tareas)
            {
                var precioTareaActual = tarea.PreciosTarea.FirstOrDefault()?.Monto;

                if (precioTareaActual != null) montoTrabajo += (float)precioTareaActual;
                e.Graphics.DrawString(tarea.Nombre + " ..... $" + precioTareaActual.ToString(), font, Brushes.Black, new RectangleF(x, y += 20, width, 20));
            }
            e.Graphics.DrawString("Monto total del trabajo $" + montoTrabajo.ToString(), font, Brushes.Black, new RectangleF(x, y += 20, width, 20));

            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(x, y += 20, width, 20));

            string fechayHoraActual = DateTime.Now.ToString();
            e.Graphics.DrawString("Fecha de emisión de ticket: " + fechayHoraActual, font, Brushes.Black, new RectangleF(x, y += 20, width, 20));
        }

        private void GenerarTicket_Load(object sender, EventArgs e)
        {
            var trabajo = _trabajoController.GetOne(_trabajoId);
            var tareas = _tareaController.GetTareasDelTrabajoList(_trabajoId);

            lblCliente.Text += trabajo.Cliente.Nombre;
            lblDispositivo.Text += trabajo.NombreDispositivo;
            lblProblema.Text += trabajo.DescripcionProblema;

            gbTareas.Controls.Clear();
            int y = 20;
            float montoTrabajo = 0;
            foreach (var tarea in tareas)
            {
                var lblTarea = new Label();
                var precioTareaActual = tarea.PreciosTarea.FirstOrDefault()?.Monto;

                if (precioTareaActual != null) montoTrabajo += (float)precioTareaActual;

                lblTarea.Text = tarea.Nombre + " ..... $" + precioTareaActual.ToString();
                lblTarea.Location = new Point(10, y);
                lblTarea.AutoSize = true;

                gbTareas.Controls.Add(lblTarea);
                y += 20;
            }
            var lblMontoTrabajo = new Label();
            lblMontoTrabajo.Text = "Monto total del trabajo $" + montoTrabajo.ToString();
            lblMontoTrabajo.Location = new Point(10, y);
            lblMontoTrabajo.AutoSize = true;
            gbTareas.Controls.Add (lblMontoTrabajo);
        }
    }
}
