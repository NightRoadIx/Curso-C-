using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TiroParabolico
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* Ejecutar cuando se carga la ventana */
        private void Form1_Load(object sender, EventArgs e)
        {
            /* Valores iniciales */
            caja1.Text = "0.0";
            caja2.Text = "0";
            caja3.Text = "0.0";
            caja4.Text = "0.0";
            caja5.Text = "Archivo";
            comboBox1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Objeto Canelo con las condiciones iniciales
            SiHayTiro canelo = new SiHayTiro(
                double.Parse(caja1.Text),
                int.Parse(caja2.Text),
                double.Parse(comboBox1.SelectedItem.ToString().Split()[1]),
                double.Parse(caja3.Text)
                );
            double tmp = 0.0;
            string cadena = "dt \t x \t y \n";

            // Calcular la posición del proyectil
            while (true)
            {

                cadena += "\n" + tmp.ToString() + "\t" + canelo.Px.ToString() +
                    "\t" + canelo.Py.ToString() + "\n";

                // En otro caso incrementar tmp
                tmp += double.Parse(caja4.Text);

                // Calcula la posición
                canelo.calcularPos(tmp);

                // Realizar hasta que la altura se igual o menor a 0
                if (canelo.Py <= 0.0) break;

            }
            textBox6.Text = cadena;
            //File.AppendAllText(caja5.Text + ".txt", cadena);
        }
    }

    public class SiHayTiro
    {
        /* Atributos */
        public double Px
        { get; set; }
        public double Py
        { get; set; }
        public double V0
        { get; }
        public int Theta
        { get; }
        public double G
        { get; }

        /* Métodos */
        // El constructor genera los valores iniciales para el cálculo
        public SiHayTiro(double vIni, int aIni, double grav, double h)
        {
            V0 = vIni;
            Theta = aIni; 
            G = grav;
            Px = 0.0;
            Py = h;  // Altura inicial
        }

        // Función para calcular la posición
        public void calcularPos(double t)
        {
            Px = V0 * Math.Cos(Theta * Math.PI / 180.0) * t;
            Py = V0 * Math.Sin(Theta * Math.PI / 180.0) * t - 0.5 * G * Math.Pow(t,2);
        }

    }
}