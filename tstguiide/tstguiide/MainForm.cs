/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 15/04/2020
 * Time: 2:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace tstguiide
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			// Modificar algunos de los elementos de la caja de texto enriquecido
			richTextBox1.BackColor =  Color.Black;
			richTextBox1.ForeColor = Color.Lime;
			richTextBox1.Font = new Font("Console", 12);
			
			// Modificar el control numérico
			numericUpDown1.BackColor = Color.Fuchsia;
			// colocar los valores que serán de 
			// mínimo
			numericUpDown1.Minimum = 0;
			// máximo del control
			numericUpDown1.Maximum = 1000;
			// y el incremento
			numericUpDown1.Increment = 1;
			// default
			numericUpDown1.Value = 666;
			
			label2.Text = "Valor de la cosa " + numericUpDown1.Value;
			
			// Modificar el Date Time Picker
			dateTimePicker1.Font = new Font("Comic Sans MS", 8);
			
			// Modificar a idioma español con Culture de Globalization
			CultureInfo cult = CultureInfo.CreateSpecificCulture("es-MX");
			// Crear un objeto de tipo DateTime que presenta la fecha
			DateTime fecha;
			fecha = dateTimePicker1.Value;
			label3.Text = "Hoy es " + cult.DateTimeFormat.GetDayName(fecha.DayOfWeek) + " día de guardar";
			
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			label2.Text = "Valor de la cosa " + numericUpDown1.Value;
		}
		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			/* Esto podría moverse a una variable global para no volver a declarar todo */
			// Modificar a idioma español con Culture de Globalization
			CultureInfo cult = CultureInfo.CreateSpecificCulture("es-MX");
			// Crear un objeto de tipo DateTime que presenta la fecha
			DateTime fecha;
			fecha = dateTimePicker1.Value;
			label3.Text = "Hoy es " + cult.DateTimeFormat.GetDayName(fecha.DayOfWeek) + " día de guardar";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			label1.Text = "No me des click!";
			label1.Font = new Font("Comic Snas MS", 14);
			label1.ForeColor  = Color.Red;
		}
		
		void Label1MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "Ingresar un texto:";
			label1.Font = new Font("Microsoft Sans Serif", 8);
			label1.ForeColor  = Color.Black;
		}
	}
}
