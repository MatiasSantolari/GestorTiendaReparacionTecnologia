using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vista
{
    public partial class InformeDemandaDeTrabajos : Form
    {
        private readonly TrabajoController _controller;
        public InformeDemandaDeTrabajos()
        {
            _controller = new TrabajoController();
            InitializeComponent();
        }

        private void InformeDemandaDeTrabajos_Load(object sender, EventArgs e)
        {
            //Agrego los años al combobox de Años
            for (int i = 2024; i <= 2100; i++)
            {
                cbAno.Items.Add(i);
            }
            cbAno.SelectedItem = DateTime.Now.Year;

            CargarGraficos(DateTime.Now.Year);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbAno.SelectedItem == null) return;

            int ano = (int)cbAno.SelectedItem;

            CargarGraficos(ano);
        }

        private void CargarGraficos(int ano)
        {
            label1.Text = "Informe anual de demanda de trabajos: año " + ano;
            var datos = _controller.GetTrabajosPorAno(ano);
            chartInformeCantidad.Series.Clear(); // limpiar series previas
            chartInformeRecaudacion.Series.Clear(); // limpiar series previas

            if (datos == null || !datos.Any())
            {
                MessageBox.Show($"No hay datos para el año {ano}");
                return;
            }

            //Grafico de barras, Cantidad de trabajos por mes
            var serieCantidad = new Series("Cantidad de trabajos por mes")
            {
                ChartType = SeriesChartType.Column, // gráfico de barras verticales
                XValueType = ChartValueType.String
            };
            // Agregar puntos al gráfico
            foreach (var d in datos.OrderBy(x => x.Mes))
            {
                string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(d.Mes);
                serieCantidad.Points.AddXY(d.Mes, d.Cantidad);
            }
            chartInformeCantidad.ChartAreas[0].AxisX.Interval = 1; // mostrar todas las etiquetas
            chartInformeCantidad.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // girar los nombres de meses si se superponen

            chartInformeCantidad.Series.Add(serieCantidad);

            //Grafico de linea, Recaudacion de trabajos por mes
            var serieRecaudacion = new Series("Recaudacion de trabajos por mes")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.String
            };
            // Agregar puntos al gráfico
            foreach (var d in datos.OrderBy(x => x.Mes))
            {
                string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(d.Mes);
                serieRecaudacion.Points.AddXY(d.Mes, d.Recaudacion);
            }
            chartInformeRecaudacion.ChartAreas[0].AxisX.Interval = 1; // mostrar todas las etiquetas
            chartInformeRecaudacion.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // girar los nombres de meses si se superponen

            chartInformeRecaudacion.Series.Add(serieRecaudacion);

            // Forzar refresco
            chartInformeCantidad.Invalidate();
            chartInformeRecaudacion.Invalidate();
        }
    }
}
