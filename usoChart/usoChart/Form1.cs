using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Se usa la librería para manipular los objetos del chart
using System.Windows.Forms.DataVisualization.Charting;

namespace usoChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();

            // Limpiar los puntos de los datos
            chart1.Series["prueba1"].Points.Clear();
            chart1.Series["prueba2"].Points.Clear();

            // Cambiar el texto de la leyenda
            chart1.Series["prueba1"].LegendText = "Puntos Aleatorios 1";
            chart1.Series["prueba2"].LegendText = "Puntos Aleatorios 2";

            chart1.Series["prueba1"].IsValueShownAsLabel = true;
            chart1.Series["prueba2"].IsValueShownAsLabel = true;

            // Añadir elementos a la gráfica
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["prueba1"].Points.AddXY(rdn.Next(0, 10), rdn.Next(0, 10));
                chart1.Series["prueba2"].Points.AddXY(rdn.Next(0, 10), rdn.Next(0, 10));
            }

            chart1.Series["prueba1"].ChartType = SeriesChartType.Spline;
            chart1.Series["prueba1"].Color = Color.Red;

            chart1.Series["prueba2"].ChartType = SeriesChartType.Spline;
            chart1.Series["prueba2"].Color = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Añadir un título a la gráfica
            chart1.Titles.Add("Nuevo Título");
            // Modificar el fondo del título
            chart1.Titles[0].BackColor = Color.Coral;

            // Dar formato a la leyenda
            chart1.Legends.Add("Leyenda1");
            chart1.Legends[0].BackColor = Color.Aquamarine;
            chart1.Legends[0].BorderColor = Color.Black;
            chart1.Legends[0].BorderWidth = 4;

            // Textos en los ejes
            chart1.ChartAreas[0].Axes[0].Title = "Eje x";
            chart1.ChartAreas[0].Axes[1].Title = "Eje y";
        }
    }
}
