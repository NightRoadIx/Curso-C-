using System;
// Se requiere usar esta librería para manejar archivos
using System.IO;

namespace cadenosos
{
	class Program
	{
		public static void Main(string[] args)
		{
			string cadena = "Esta es una cadena de prueba para escribir en un archivo";
			/* MÉTODOS DE LECTURA-ESCRITURA DE ARCHIVOS */
			// El método WriteAllText(string archivo, string datos)
			// Crea si no existe, o sobreescribe un archivo si existe 
			// y escribe lo que se coloca en la cadena datos
			File.WriteAllText("Prueba.txt", cadena);
			
			// En cambio, el método AppendAllText(sting archivo, string datos)
			// En caso de que el archivo no exista lo genera, en caso de que si exista
			// agrega al final del archivo la cadena de texto datos
			File.AppendText("Prueba.txt", cadena);
			
			// En el caso de lectura, se puede usar el método
			// ReadAllText(string archivo), que leerá todo el texto que contiene el archivo
			Console.WriteLine(File.ReadAllText("Prueba.txt"));
			
			// En caso de utilizar el método ReadLines(string archivo)
			// este leerá línea por línea (con separación de '\n' o salto de línea)
			// almacenandose en un arreglo de cadenas con iterador, por lo que se tiene
			// que utilizar foreach para recorrerlo
			foreach(string s in File.ReadLines("Prueba.txt"))
				Console.Write(s);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}