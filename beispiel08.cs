/*
 * Programa que muestra el uso de las funciones de consola
 * Cambia el título de la ventana, color de fondo, color de texto
 */
using System;

namespace etereal
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			// Modificación del tamaño del cursor, los valores que toma
			// son de 1 a 100, esto es el procentaje de pixeles que se muestran
			Console.CursorSize = 50;	// 1, 20, 30, ..., 100
			// Modificación del color de la letra
			Console.ForegroundColor = ConsoleColor.Green;
			// Modificación del color de fondo de la letra
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Presione una tecla pa' seguir . . . ");
			// Esta fuynción espera que se presione una tecla (puede leerse el resultado como un char)
			Console.ReadKey(true);
			// Modificar la visibilidad del cursor
			Console.CursorVisible = false;
			Console.Write("Etereal");
			// Modificar el título de la ventana
			Console.Title = "Mi ventanita de los horrores";
			Console.ReadKey(true);
			Console.CursorVisible = true;
			Console.ReadKey(true);
			
			/* 
			 * Los siguiente posiciona el cursor en algún punto de la ventana
			 * su uso es
			 *
			 * Console.SetCursorPosition(columna,fila);
			 *
			 */
			Console.SetCursorPosition(0,5);
			Console.Write("Efor");
			Console.ReadKey(true);
			// Lo siguiente permite modificar el color de fondo de toda la pantalla
			Console.BackgroundColor = ConsoleColor.DarkRed;
			// Con esto se limpia la consola de todo lo que se haya escrito
			Console.Clear();
			// Esto muestra el número máximo de columnas y filas disponibles
			Console.WriteLine("{0} {1}", Console.LargestWindowWidth, Console.LargestWindowHeight);
			// Modifica el tamaño de la ventana, más no los máximos donde se puede escribir
			Console.SetWindowSize(40,40);
			Console.ReadKey(true);
			// Dar un reset al color de fondo y de letra
			Console.ResetColor();
			// Generar un pitido
			Console.Beep();
			// El pitido se puede controlar en frecuencia y duración del sonido (milisegundos)
			// Console.Beep(frecuencia, duracion);
			Console.Beep(440, 100);
			
			Console.ReadKey(true);
			
		}
	}
}