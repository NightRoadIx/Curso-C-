using System;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace antigua
{
	class Program
	{
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
		
		private static void Maximize()
		{
		    Process p = Process.GetCurrentProcess();
		    ShowWindow(p.MainWindowHandle, 3);
		}

		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			int i;
			Random aleat = new Random();
			ConsoleColor[] colores = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
			Maximize();
			for(i = 0; i <= 100; i++)
			{
				foreach(var color in colores)
				{
					Console.BackgroundColor = color;
					Console.Clear();
					Console.ForegroundColor = colores[aleat.Next(0,15)];
					Console.SetCursorPosition(aleat.Next(0,70),aleat.Next(1,30));
					Console.Write("EPILEPSIA");
					Thread.Sleep(aleat.Next(1,50));
				}
				//Console.SetCursorPosition(75,5);
			}
			
			Console.ReadKey(true);
		}
	}
}