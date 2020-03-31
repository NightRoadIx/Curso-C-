/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 17/03/2020
 * Time: 1:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace imaginasizacion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string nombreImagen;
		
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
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Text = "Image";
			// Desactivar botón salvar
			button2.Enabled = false;
			
			nombreImagen = "";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Instanciando el objeto OpenFileDialog
			OpenFileDialog opf = new OpenFileDialog();
			
			opf.Filter = "Elegir una imagen (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
			
			if( opf.ShowDialog() == DialogResult.OK )
			{
				pictureBox1.Image = Image.FromFile(opf.FileName);
				nombreImagen = opf.FileName;
				label1.Text = opf.FileName;
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if( (textBox1.Text.Trim().Length > 0)&&( nombreImagen != "" ) )
				button2.Enabled = true;
			else
				button2.Enabled = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			File.WriteAllText((textBox1.Text+".txt"), nombreImagen);
		}
	}
}
