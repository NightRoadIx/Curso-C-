/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 12/04/2022
 * Time: 12:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// Incluir la parte de expresiones regulares
using System.Text.RegularExpressions;
// Incluir la parte de lectura/escritura de archivos
using System.IO;

namespace CURPGUI
{
	/// <summary>
	/// Description of MainForm
	/// </summary>
	public partial class MainForm : Form
	{
		// Diccionario para guardar la información de los estados
		public Dictionary<string, string> estates = new Dictionary<string, string>();
		
		// Funciones
		// Obtener las consonantes de la cadena
		public string obtenerConsonantes(string cadena)
		{
			string conson = Regex.Replace(cadena, "(?<!^)[aeiouáéíóú](?!$)", "");
			return conson;
		}
		// Obtener las vocales de la cadena
		public string obtenerVocales(string cadena)
		{
			string vocale = Regex.Replace(cadena, "([^aeiouáéíóú\\W]+)", "");
			return vocale;
		}
		// Eliminar los espacios de una cadena
		public string sinEspacios(string cadena)
		{
			string ohneSpace = Regex.Replace(cadena, @"\s+", "");
			return ohneSpace;
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
		
		// Función asociada al evento carga de formulario
		void MainFormLoad(object sender, EventArgs e)
		{
			foreach(string s in File.ReadLines("estados.txt"))
			{
				// Separar la cadena leída con una ','
				var linea = s.Split(',');
				// Cargar la información en el combobox
				comboBox1.Items.Add(linea[0]);
				
				// Asignar al diccionario
				estates.Add(linea[0], linea[1]);
			}
		}
		
		// Función asociada al evento clic del ratón
		void Button1Click(object sender, EventArgs e)
		{
			/* SECCIÓN DEL NOMBRE */
			string ini = "";
			ini += textBox2.Text[0];
			ini += obtenerVocales(textBox2.Text)[0];
			ini += textBox3.Text[0];
			ini += textBox1.Text[0];
			
			/* SECCIÓN DE FECHA */
			string anno = dateTimePicker1.Value.Year.ToString().Substring(2,2);			
			int tmp = dateTimePicker1.Value.Month;
			string mess = tmp < 10 ? "0" + tmp.ToString() : tmp.ToString();
			tmp = dateTimePicker1.Value.Day;
			string diaa = tmp < 10 ? "0" + tmp.ToString() : tmp.ToString();
			
			/* SELECCIÓN DE SEXO */
			string sexo = "";
			if( radioButton1.Checked )
				sexo = "H";
			else if( radioButton2.Checked )
				sexo = "M";
			else
				sexo = "I";
			
			/* SELECCIÓN DE LA CLAVE DEL ESTADO */
			string claveEstado; 
			estates.TryGetValue(comboBox1.SelectedItem.ToString(), out claveEstado);
			
			/* CLAVE ADICIONAL */
			string adic = "";
			adic += obtenerConsonantes(textBox2.Text)[1];
			adic += obtenerConsonantes(textBox3.Text)[1];
			adic += obtenerConsonantes(textBox1.Text)[1];
			
			// Colocar el valor del CURP
			textBox5.Text = ini.ToUpper() + anno + mess + diaa + sexo + claveEstado + adic.ToUpper();
		}		
	}
}
