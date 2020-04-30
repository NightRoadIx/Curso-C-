using System;
using System.IO;
using System.Collections.Generic;
using System.Net;

namespace leetura
{
	class Program
	{
		public static string obtenerCSV(string url)
		{
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			
			StreamReader sr = new StreamReader(resp.GetResponseStream());
			string results = sr.ReadToEnd();
			sr.Close();
			
			return results;
		}
		
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			string archon = obtenerCSV("http://samplecsvs.s3.amazonaws.com/SalesJan2009.csv");
			
			Console.WriteLine(archon);
			
			Console.ReadKey(true);
			// Leer el archivo nba.csv por medio de StreamReader
			// using() funciona como una especie de try - catch()
			// para evitar que no ejecuten las siguientes instrucciones
			using(var letor = new StreamReader("nba.csv"))
			{
				// Generar dos listas para guardar datos
				List<string> nombre = new List<string>();
				List<string> equipo = new List<string>();
				
				// Mientras lo que se haya leído no haya llegado al fin de archivo
				while (!letor.EndOfStream)
				{
					// Leer línea por línea
					var linia = letor.ReadLine();
					// Después separar la cadena de texto leída por medio de una ","
					var valores = linia.Split(',');
					
					// Añadir a cada una de las listas generadas
					nombre.Add(valores[0]);
					equipo.Add(valores[1]);
					
				}
				
				// Mostrar los datos obtenidos
				for(int i = 0;  i < nombre.Count; i++)
					Console.WriteLine("{0}\t\t{1}", nombre[i], equipo[i]);
				
			}
						
			Console.ReadKey(true);
		}
	}
}