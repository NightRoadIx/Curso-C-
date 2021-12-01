/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 30/11/2021
 * Time: 05:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FibonacciGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		/* VARIABLES O PROPIEADES */
		List <int> arregloF = new List<int>();
		int n, nim = 0, xam = 46;
		
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		/* Cuando se de clic al botón button1 */
		void Button1Click(object sender, EventArgs e)
		{
			// Revisar que los valores ingresados sean los correctos
			if( (!Int32.TryParse(textBox1.Text, out n))||((n <= nim)||(n > xam)) )
			{
				MessageBox.Show("Error mortal, el número " + textBox1.Text + " está fuera del intervalo [" + nim.ToString() + "," + xam.ToString() + "]", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// Una vez que se le haya dado el OK a la ventanita, pues continua con esta parte del programa
				// Limpiar la caja de texto
				textBox1.Text = "";
				// Colocar el foco a la caja de texto
				textBox1.Focus();			
			}
			else
			{
				// Limpiar la caja de texto2 para presentar la serie
				textBox2.Text = "";
				// Calcular la serie con los datos y llenar en la caja de texto con los valores
				for(int k = 0, a = 1, b = 0, c = 0; k < this.n; c = a + b, a = b, b = c, k++)
				{
					arregloF.Add(c);
					textBox2.Text += c.ToString() + ",";
				}
			}
		}
		
		/* Cuando el usuario ingresa un valor a la textBox1 */
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			// Con esto se asegura que solamente se ingresen valores numéricos
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
			// Cuando se presione la tecla "Enter" pues simplemente realiz aun click
			if( e.KeyChar == (char)Keys.Return )
				button1.PerformClick();
		}
	}
}
