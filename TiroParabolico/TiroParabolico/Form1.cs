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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace TiroParabolico
{

    public partial class Form1 : Form
    {
        // Atributos de la clase Form1 (la ventana)
        public string cadena = "dt,x,y\n";
        public string posX;
        public string posY;
        // Este es una clase para comunicación con Arduino
        // mediante el puerto serial, esto es un objeto que
        // representa a dicho puerto
        System.IO.Ports.SerialPort ArduinoPort;

        // Métodos de la clase Form1
        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Crear el objeto para el serial port
            // Se hace la llamada al constructor...
            // Al declaralo, le indicamos al compilador que se
            // generará un objeto de dicho tipo
            // (System.IO.Ports.SerialPort), pero hasta aquí
            // ya se reserva la memoria
            ArduinoPort = new System.IO.Ports.SerialPort();
            // Ahora si, tenemos acceso a los stributos del objeto
            // que sirven para la configuración
            ArduinoPort.PortName = "COM8";
            ArduinoPort.BaudRate = 9600;
            try
            {
                // Y se abre la comunicación con el método correspondiente
                ArduinoPort.Open();
                if (ArduinoPort.IsOpen)
                {
                    label13.Text = "Conectado";
                    label13.ForeColor = Color.Green;
                    ArduinoPort.Write("a");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error mortal " + error.ToString(), "Título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            textBox1.Text = "Grafica";
            comboBox1.SelectedIndex = 2;
            label14.Text = "0.00 %";

            /* Configurar la gráfica */
            // Liimpiar la gráfica
            this.chart1.Series[0].Points.Clear();
            // Hacer invisible la leyenda
            this.chart1.Series[0].IsVisibleInLegend = false;
            // Colocar el valor del eje x mínimo como 0
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            // Colocar el formato de los números del eje x con 2 dígitos
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";
            // Etiqueta del eje x
            this.chart1.ChartAreas[0].AxisX.Title = "x [m]";
            // Etiqueta del eje y
            this.chart1.ChartAreas[0].AxisY.Title = "y [m]";
        }

        /* Método para cuando se hace clic en el botón3 */
        private void button3_Click(object sender, EventArgs e)
        {
            double tmp = 0.0;

            // Limpiar la barra de progreso
            progressBar1.Value = 0;

            // Limpiar la gráfica
            this.chart1.Series[0].Points.Clear();

            // Objeto Canelo con las condiciones iniciales
            SiHayTiro canelo = new SiHayTiro(
                double.Parse(caja1.Text),
                int.Parse(caja2.Text),
                double.Parse(comboBox1.SelectedItem.ToString().Split()[1]),
                double.Parse(caja3.Text)
                );

            // Valores iniciales
            this.posX = "0.0";
            this.posY = caja3.Text;

            // Iniciar LED verde en el Arduino
            ArduinoPort.Write("b");
            // Apagar el LED rojo
            ArduinoPort.Write("a");

            // Calcular la posición del proyectil
            while (true)
            {                
                // Se genera la cadena de texto que se guardará
                cadena += String.Format("{0},{1},{2}\n", tmp, canelo.Px, canelo.Py);
                
                // Colocar los puntos de la gráfica
                this.chart1.Series[0].Points.AddXY(canelo.Px, canelo.Py);

                // En otro caso incrementar tmp
                tmp += double.Parse(caja4.Text);

                // Calcula la posición
                canelo.calcularPos(tmp);

                // Almacenar los puntos
                this.posX += String.Format("{0:0.00}", canelo.Px);
                this.posY += String.Format("{0:0.00}", canelo.Py);
                // Realizar hasta que la altura se igual o menor a 0
                if (canelo.Py <= 0.0) break;
                this.posX += ",";
                this.posY += ",";

                // label14.Text = ;
                // progressBar1.Value = ;

            }

            // Hacer que la parte para salvar imágenes este disponible
            label12.Visible = true;
            caja5.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            label11.Visible = true;
            button4.Visible = true;
            textBox1.Visible = true;

            // Apagar el LED verde
            ArduinoPort.Write("b");
            // Encender el LED rojo
            ArduinoPort.Write("a");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText(caja5.Text + ".csv", cadena);
                MessageBox.Show("Archivo " + caja5.Text + ".csv salvado con éxito", "Título", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception error)
            {
                MessageBox.Show("Error mortal " + error.ToString(), "Título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {                
                this.chart1.SaveImage(textBox1.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Archivo " + textBox1.Text + ".jpg salvado con éxito", "Título", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error mortal " + error.ToString(), "Título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFirebaseConfig ifc = new FirebaseConfig()
            {
                AuthSecret = "N2gqlG23f79epceVhGDCMFauFiDXdS35BHbqibTo",
                BasePath = "https://snoopdogg-631cb-default-rtdb.firebaseio.com"
            };

            IFirebaseClient cliente;

            try
            {
                cliente = new FireSharp.FirebaseClient(ifc);

                // Apagar LED rojo
                ArduinoPort.Write("a");
                // Encender el azul
                ArduinoPort.Write("c");
                // Generar el objeto que se va a guardar en la BD
                TiroTiro tmp = new TiroTiro(
                    double.Parse(caja1.Text),
                    int.Parse(caja2.Text),
                    double.Parse(comboBox1.SelectedItem.ToString().Split()[1]),
                    double.Parse(caja3.Text),
                    this.posX,
                    this.posY
                    );
                // Obtener la fecha para almacenar en la BD
                // cuando es que se generó la simulación
                string fecha = DateTime.Now.ToString("ddMMyyyy_hhmmss");
                // Guardar en la BD
                cliente.Set(fecha + "/", tmp);
                
                MessageBox.Show("Acceso a base de datos " + ifc.BasePath + " y guardado de manera correcta", "Título", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Encender LED rojo
                ArduinoPort.Write("a");
                // Apagar el azul
                ArduinoPort.Write("c");
            }
            catch(Exception error)
            {
                MessageBox.Show("Error mortal " + error.ToString() + " No se pudo realizar la conexión con la base de datos", "Título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar el puerto cuando la ventana se cierre
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Write("a");
                // Cerrar la comunicación, esto es muy importante
                ArduinoPort.Close();
            }
        }

        private void caja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // con esto se asegura que solo se ingresan valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void caja1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // con esto se asegura que solo se ingresan valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

    /* Clase para guardar los datos */
    public class TiroTiro
    {
        public double V0
        { get; set; }
        public int Theta
        { get; set; }
        public double H0
        { get; set; }
        public double G
        { get; set; }
        public string Px
        { get; set; }
        public string Py
        { get; set; }

        public TiroTiro(double vIni, int aIni, double grav, double h, string posX, string posY)
        {
            this.V0 = vIni;
            this.Theta = aIni;
            this.G = grav;
            this.H0 = h;
            this.Px = posX;
            this.Py = posY;
        }
    }

    public class SiHayTiro
    {
        /* Atributos */
        public double Px
        { get; set; }
        public double Py
        { get; set; }
        public double Py0
        { get; }
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
            Py0 = h;
        }

        // Método para calcular la posición
        public void calcularPos(double t)
        {
            Px = V0 * Math.Cos(Theta * Math.PI / 180.0) * t;
            Py = Py0 + V0 * Math.Sin(Theta * Math.PI / 180.0) * t - 0.5 * G * Math.Pow(t,2);
        }

        // Método para calcular la altura máxima
        public double calcularPosYMax(double h)
        {
            double posYMax = ((Math.Pow(V0, 2)) * Math.Sin(Theta * Math.PI /180.0)) / 2*G;
            return posYMax + h;
        }

    }
}