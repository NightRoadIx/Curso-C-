/*
 * Programa para la lectura de un archivo CSV
 * Los archivos CSV (Comma Separated Values, valores separados por comas) se utilizan mucho para el 
 * intercambio de grandes cantidades d einformación a través de la web, así como para el análisis de estos datos
 * con la finalidad de hallar patrones o información útil, muy utilizados en ciencia de datos.
 * 
 * En este programa se muestra como leer un archivo CSV, ya sea desde una URL (Uniform Resource Locator) o
 * si el archivo ya está en un disco local
 * */
using System;
using System.IO;
using System.Collections.Generic;
using System.Net;	// ´Paquetería para manejar archivos desde una URL

namespace leetura
{
	class Program
	{
		/* Función para obtener el contenido de un archivo de una URl en formato de cadena de texto */
		public static string obtenerCSV(string url)
		{
			// Se crea el pedido de una URL
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			// Aquí es donde se manejará la respuesta que entregue esta URL
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			
			// Depués se crea un "streaming" para la lectura "en directo" del archivo solicitado
			StreamReader sr = new StreamReader(resp.GetResponseStream());
			// Se leerá el archivo hasta el final para asignarlo a una cadena de texto
			string results = sr.ReadToEnd();
			// IMPORTANTRE: Cerrar el streaming de lectura
			sr.Close();
			
			return results;
		}
		
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			// Llamar a la función para obtener un archivo CSV direcyamente de una URL
			string archon = obtenerCSV("http://samplecsvs.s3.amazonaws.com/SalesJan2009.csv");
			
			// Escribir todo el contenido del archivo
			Console.WriteLine(archon);
			// Esperar que se presione una tecla 
			Console.Write("Presione una tecla para continuar-->");
			Console.ReadKey(true);
			// Limpiar la consola
			Console.Clear();
			
			// Leer el archivo nba.csv por medio de StreamReader
			// using() funciona como una especie de try - catch()
			// para evitar que no ejecuten las siguientes instrucciones
			int j = 0;	// Contador de líneas
			using(var letor = new StreamReader("nba.csv"))
			{
				// Generar dos listas para guardar datos
				List<string> nombre = new List<string>();
				List<string> equipo = new List<string>();
				
				// En esta cadena se guardarán los encabezados del archivo
				string encabeza = "";
				
				// Mientras lo que se haya leído no haya llegado al fin de archivo
				while (!letor.EndOfStream)
				{
					// Leer línea por línea
					var linia = letor.ReadLine();
					// Primera línea (encabezados)
					if(j == 0)
						encabeza = linia;	//Asgnar la cadena de texto
					// Después separar la cadena de texto leída por medio de una ","
					var valores = linia.Split(',');
					
					// Añadir a cada una de las listas generadas
					nombre.Add(valores[0]);
					equipo.Add(valores[1]);
					
					// Incrementar el número de líneas leídas
					j++;
					
				}
				
				// Mostrar los datos obtenidos
				for(int i = 0;  i < nombre.Count; i++)
					Console.WriteLine("{0}\t\t{1}", nombre[i], equipo[i]);
				
				Console.WriteLine("\n\n");
				Console.WriteLine("Se han leído: {0} líneas", j+1);
				Console.WriteLine("Cuyo encabezado es: ");
				Console.WriteLine(encabeza);
				
			}
						
			Console.ReadKey(true);
		}
	}
}
