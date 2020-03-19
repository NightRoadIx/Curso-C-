/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 18/03/2020
 * Time: 19:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ventanizacion
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
		
		/* Este el el método cuando la ventana se genera */
		void MainFormLoad(object sender, EventArgs e)
		{
			// Modificar los atributos del label1
			label1.Text = "Nombre: ";
			label1.ForeColor = Color.Firebrick;
			
			// Modificar el atributo de "Enabled" (habilitado) del button2
			button2.Enabled = false;
		}
		
		/* Método para cuando se presiona el Button1 */
		void Button1Click(object sender, EventArgs e)
		{
			// Se cambia el atributo Enabled de Button2
			button2.Enabled = true;
		}
		
		/* Método para cuando se presiona el Button2 */
		void Button2Click(object sender, EventArgs e)
		{
			// Salir de la aplicación
			Application.Exit();
		}
	}
}
