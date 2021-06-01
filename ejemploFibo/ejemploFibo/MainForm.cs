/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 01/06/2021
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejemploFibo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		/* Atributos de clase */
		
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
		
		void Button1Click(object sender, EventArgs e)
		{
			// Variable para almacenar el valor de la caja de texto
			long valorN, a, b, c;
			int k;
			// Lista para generar los datos de la serie
			List<long> arregloF = new List<long>();
			
			if( !Int64.TryParse(textBox1.Text, out valorN) || ( (valorN < 1)||(valorN > 64) ) )
			{
				MessageBox.Show("Error mortal, el número " + textBox1.Text + " esta fuera del intervalo", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox1.Text = "";
				textBox1.Focus();
			}
			else
			{
				textBox2.Text = "";
				// Calcular la serie con los datos y llenar en la caja de texto correspondiente
				for(k = 0, a = 1, b = 0, c = 0; k < valorN; c = a + b, a = b, b = c, k++)
				{
					arregloF.Add(c);
					textBox2.Text += c.ToString() + ",";
				}
			}			
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			// con esto se asegura que solo se ingresan valores numéricos
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
			{
				e.Handled = true;
			}		
		}
	}
}
