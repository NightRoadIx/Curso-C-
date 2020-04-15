using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chirsCornell
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
			// Generar una variable del tipo checkedListBox en sus items
			var itens = checkedListBox1.Items;
			// Ir añadiendo
			itens.Add("Perlas");
			// Colocar cuando está seleccionado
			itens.Add("Ostras", true);
			itens.Add("Bivalvos");
			
			label1.Text = "";
			
			// Link Label
			linkLabel1.BackColor = Color.Red;
			linkLabel1.ForeColor = Color.Blue;
			linkLabel1.Text = "Ir a mi página";
			linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
			linkLabel1.Font = new Font("Georgia", 16);
			
			// Temporizador
			timer1.Enabled = false;
			label2.Text = "0 %";
			
			// Deshabilitar todo
			checkedListBox1.Enabled = false;
			button1.Enabled = false;
			linkLabel1.Enabled = false;
		}
		
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			// Para obtener el índice de la lista
			int seleccion = checkedListBox1.SelectedIndex;
			// Esto es cuando no hay alguno seleccionado y prevenir un IndexOutOfRangeException
			if(seleccion != -1)
			{
				// Convertir a texto, Items es una lista
				label1.Text = checkedListBox1.Items[seleccion].ToString();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// Determinar si hay algún item seleccionado
			if(checkedListBox1.CheckedItems.Count != 0)
			{
				// Si existen, entonces recorrer todos los items e imprimir el resultado
				string s = "";
				int x;
			
				for(x = 0; x < checkedListBox1.CheckedItems.Count; x++)
					s = s + "Item " + (x+1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
				MessageBox.Show(s);
			}
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.LinkVisited = true;
			System.Diagnostics.Process.Start("http://verikosesi.rf.gd/index.html");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer1.Start();
			timer1.Interval = 1000; // 1 s
			progressBar1.Maximum = 10; // a 10 segundos
			timer1.Tick += new EventHandler( Timer1Tick );
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if(progressBar1.Value < 10)
			{
				progressBar1.Value++;
				label2.Text = (progressBar1.Value * 10).ToString() + " %";
			}
			else
			{
				timer1.Stop();
				checkedListBox1.Enabled = true;
				button1.Enabled = true;
				linkLabel1.Enabled = true;
				
				button2.Enabled = false;
				progressBar1.Enabled = false;
			}
		}
	}
}
