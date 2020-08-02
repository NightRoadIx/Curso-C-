using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace poblacionizacion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		/*Atributos (variables globales)*/
		// Crear una lista para almacenar los encabezados
		List<string> hutt = new List<string>();
		// Crear una lista para almacenar los años
		List<string> anno = new List<string>();
		// Lista para guardar todos los datos
		List<string[]> data = new List<string[]>();
		
		string[] arch = {"0"};
		
		/* Métodos personalizados */
		public void cambio()
		{
			// Variables locales
			List<string> tmp = new List<string>();
			
			int maximo = int.MinValue;
			int minimo = int.MaxValue;
			long total = 0;
			double promedio = 0.0;
			
			// Hay que verificar el texto del combobox (o su índice también) para identificar que es lo que se va a obtener
			// Obtener el índice del elemento seleccionado
			int i = comboBox1.SelectedIndex + 1;
			int j = comboBox2.SelectedIndex;
			
			// Obtener todos los datos de la selección
			foreach(string[] r in data)
			{
				// Añadir los valores a la lista temporal
				tmp.Add(r[i]);
				
				// Obtener la suma de todos los valores
				total += Convert.ToInt32(r[i]);
				
				// Obtener máximo de la lista
				if( Convert.ToInt32(r[i]) > maximo )
					maximo = Convert.ToInt32(r[i]);
				// Obtener el mínimo de la lista
				if( Convert.ToInt32(r[i]) < minimo )
					minimo = Convert.ToInt32(r[i]);
				
			}
			// Obtenemos el promedio
			promedio = (double)total / (double)tmp.Count;
			
			/* Esta es la zona peligrosa, dado que hay cambios cada que se
			  * añade un elemento al combobox, es necesario colocar bloques
			  * try - catch para evitar errores, pues los índices pueden no
			  * coincidir 
			  * */
			// Se usa un bloque para cada índice (podría usarse uno en general)
			try{
				label3.Text = "Población " + anno[j] + ":";
				textBox1.Text = tmp[j];
			}
			catch(Exception e){
			}
						
			// 
			try {
				pictureBox1.Image = Image.FromFile(arch[i-1]);
			}
			catch(Exception e){
			}
			
			// Mostrar los valores calculados
			textBox2.Text = minimo.ToString();
			textBox3.Text = maximo.ToString();
			textBox4.Text = promedio.ToString();
			
			/*
			// Se propone usar este bloque
			// El cual incluye el uso de finally para ejecutar la muestra de los 
			// valores calculados
			try{
				label3.Text = "Población " + anno[j] + ":";
				textBox1.Text = tmp[j];
				pictureBox1.Image = Image.FromFile(arch[i-1]);
			}
			catch(Exception e){
			}
			finally {
				// Mostrar los valores calculados
				textBox2.Text = minimo.ToString();
				textBox3.Text = maximo.ToString();
				textBox4.Text = promedio.ToString();
			}*/
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// Cuando la ventana se crea
		void MainFormLoad(object sender, EventArgs e)
		{
			// Variables locales
			int j = 0;		// Contador de líneas
			
			// Lectura del archivo CSV
			using(var lector = new StreamReader("urban_pop.csv"))
			{
				// Hasta el fin del archivo
				while(!lector.EndOfStream)
				{
					// Leer línea por línea ('\n')
					var linia = lector.ReadLine();
					
					// Encabezado
					if(j == 0)
					{
						// Recorrer elemento a elemento y añadir a una lista
						foreach(string en in linia.Split(','))
							hutt.Add(en);
					}
					else
					{
						// Añadir los elementos de la tabla
						data.Add(linia.Split(','));
						// Se añaden los años
						anno.Add( linia.Split(',')[0] );
					}
					// contador de líneas leídas
					j++;
				}
				
				/* Leídos los datos, comenzar a llenar los espacios de la GUI */
				hutt.RemoveRange(0,1);
				foreach(string p in hutt)
					comboBox1.Items.Add(p);
				comboBox1.Text = comboBox1.Items[0].ToString();
				
				// Colocar los años
				foreach(string a in anno)
					comboBox2.Items.Add(a);
				comboBox2.Text = comboBox2.Items[0].ToString();
				
				/* Colocar las banderas */
				// encontrar el directorio del programa
				string directorio = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
				// localizamos los subdirectorios
				string[] subd = Directory.GetDirectories(directorio, "img*");
				// Obtenemos todos los archivos en el subdirectorio
				arch = Directory.GetFiles(subd[0]);
				// Cargar la primera imagen
				pictureBox1.Image = Image.FromFile(arch[0]);
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			cambio();
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			cambio();
		}
	}
}