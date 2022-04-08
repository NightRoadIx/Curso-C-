/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 08/04/2022
 * Time: 12:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ElRFCFinal
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
		
		void Button1MouseEnter(object sender, EventArgs e)
		{

		}
		
		void Button1MouseHover(object sender, EventArgs e)
		{

		}
		
		void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			// Objeto aleatorio
			var rand = new Random();
			
			// Se obtiene el valor aleatorio
			int x = rand.Next(1,this.Size.Width-button1.Size.Width);
			int y = rand.Next(1,this.Size.Height-button1.Size.Height);
			
			button1.Location = new Point(x, y);						
		}
	}
}
