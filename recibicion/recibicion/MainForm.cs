/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 31/03/2020
 * Time: 23:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace recibicion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		/* Método cuando la ventana se carga */
		void MainFormLoad(object sender, EventArgs e)
		{
			// Inahbilitar todos los controles excepto el Combobox1
			comboBox2.Enabled = false;
			comboBox3.Enabled = false;
			comboBox4.Enabled = false;
			comboBox5.Enabled = false;
			comboBox6.Enabled = false;
			comboBox7.Enabled = false;
			comboBox8.Enabled = false;
			button1.Enabled = false;
			label9.Text = "";
		}
		
		/* Método cuando se selecciona un valor en el ComboBox para el Dominio */
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			// Cuando se selecciona el Dominio Eukarya se rellenan los valores del segundo ComboBox
			if( comboBox1.Text == "Eukarya" )
			{
				comboBox2.Items.Add("Protista");
				comboBox2.Items.Add("Fungi");
				comboBox2.Items.Add("Plantae");
				comboBox2.Items.Add("Animalia");
				// Se activa el combobox2
				comboBox2.Enabled = true;
			}
		}
		
		/* Selección del Reino */
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Clase = {"Aneelida", "Arthropoda", "Brachiopoda", "Bryozoa", "Chordata", "Echinodermata", "Hemicohordata", "Loricefera", "Mammalia", "Mollusca", "Nematoda", "Phoronida", "Rhombozoa", "Tardigrada"};
			if(comboBox2.Text == "Animalia")
			{
				foreach(string c in Clase)
					comboBox3.Items.Add(c);
				comboBox3.Enabled = true;
			}
			else
			{
				comboBox3.Items.Clear();
				comboBox3.Text = "";
				comboBox3.Enabled = false;
			}
		}
		
		/* Selección de la Clase */
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Orden = {"Artilodacta","Carnivora","Chiroptera","Dinocerata","Litopterna","Mulituberculata","Primates","Rodentia","Scadentia"};
			if(comboBox3.Text == "Mammalia")
			{
				foreach(string c in Orden)
					comboBox4.Items.Add(c);
				comboBox4.Enabled = true;
			}
			else
			{
				comboBox4.Items.Clear();
				comboBox4.Text = "";
				comboBox4.Enabled = false;
			}
		}
		
		/* Selección del Orden */
		void ComboBox4SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Familia = {"Canidae", "Felidae", "Herpestidae","Hyanidae","Mustelidae","Ursidae"};
			if(comboBox4.Text == "Carnivora")
			{
				foreach(string c in Familia)
					comboBox5.Items.Add(c);
				comboBox5.Enabled = true;
			}
			else
			{
				comboBox5.Items.Clear();
				comboBox5.Text = "";
				comboBox5.Enabled = false;
			}			
		}
		
		/* Selección de la Familia */
		void ComboBox5SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Genero = {"Acinonyx", "Caracal", "Felis", "Leopardus", "Lynx", "Puma", "Panthera"};
			if(comboBox5.Text == "Felidae")
			{
				foreach(string c in Genero)
					comboBox6.Items.Add(c);
				comboBox6.Enabled = true;
			}
			else
			{
				comboBox6.Items.Clear();
				comboBox6.Text = "";
				comboBox6.Enabled = false;
			}	
		}
		
		/* Selección de la Especie */
		void ComboBox6SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Especie = {"bieti", "catus", "chaus", "margarita", "nigripes", "silvestris"};
			if(comboBox6.Text == "Felis")
			{
				foreach(string c in Especie)
					comboBox7.Items.Add(c);
				comboBox7.Enabled = true;
			}
			else
			{
				comboBox7.Items.Clear();
				comboBox7.Text = "";
				comboBox7.Enabled = false;
			}
		}
		
		/* Selección de la Raza */
		void ComboBox7SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] Raza = {"Abisinio", "Angora", "Bengala", "Bombay", "Bosque de Noruega", "Cornish rex", "Europeo común", "Himalayo", "Ocicat", "Oriental", "Persa", "Siamés", "Siberiano"};
			if(comboBox7.Text == "catus")
			{
				foreach(string c in Raza)
					comboBox8.Items.Add(c);
				comboBox8.Enabled = true;
			}
			else
			{
				comboBox8.Items.Clear();
				comboBox8.Text = "";
				comboBox8.Enabled = false;
			}	
		}
		
		void ComboBox8SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox8.Text != "")
			{
				button1.Enabled = true;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Alinear el texto a la mitad
			label9.TextAlign = ContentAlignment.MiddleCenter;
			// La propiead Font es de solo lectura, por lo que se debe crear mediante un constructor
			label9.Font = new Font("Arial", 16.0F, FontStyle.Bold);
			// Cambiar el color
			label9.ForeColor = Color.Red;
			label9.Text = "Es un gato " + comboBox8.Text;
		}
	}
}
