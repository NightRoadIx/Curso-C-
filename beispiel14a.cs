using System;
using System.IO;

namespace archivosos2
{
	class Program
	{
		public static void Main(string[] args){
			
			// Crear una variable donde se guardará el texto a escribir
			string tabla;
			int x;
			
			// Generar una tabla de datos
			tabla = "x\t\tx^2\n";
			for(x = 1; x <= 10; x++)
			{
				// Crear la cadena de texto a guardar (observar los 4 dígitos de precisión para x^2)
				tabla += (x.ToString() + "\t\t" + Math.Pow(x,2).ToString("N4") + "\n");
			}
			
			// Mostrar toda la tabla
			Console.WriteLine(tabla);
			
			// Ahora si escribir en el archivo
			File.WriteAllText("archivo.txt", tabla);
			
			Console.ReadKey();
			
		}
	}
}