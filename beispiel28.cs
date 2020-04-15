using System;
using System.Collections.Generic;

namespace dipcionarios
{
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			// Crear un diccionario, los diccionarios es una colección genérica que es utilizada
			// para almacenar pares de datos llave/valor, por ejemplo:
			// 1: "uno"
			// 2: "dos"
			// 3: "tres"
			// Donde los número son las llaves, mientras que las cadenas de texto son los valores
			// Se inicia con el constructor
			Dictionary<int, string> miDicc = new Dictionary<int, string>();
			
			// Añadir los pares de datos usando el método .Add()
			miDicc.Add(1, "uno");
			miDicc.Add(2, "dos");
			miDicc.Add(3, "tres");
			miDicc.Add(4, "cuatro");
			
			// Recorrer el diccionario
			// Se usa el tipo KeyValuePair para recorrer
			foreach(KeyValuePair<int, string> ele in miDicc)
			{
				Console.WriteLine("{0} con valor {1}", ele.Key, ele.Value);
			}
			
			// Se puede usar el método .Remove(key) para eliminar el elemento
			// identificado con la llave "key"
			miDicc.Remove(4);
			
			// Revisar si el elemento existe dentro del diccionario
			// Se puede hacer de dos formas, por medio de la llave:
			if( miDicc.ContainsKey(2) == true )
				Console.WriteLine("El elemento existe");
			else
				Console.WriteLine("El elemento NO existe");
			
			// O por medio del valor:
			if( miDicc.ContainsValue("cuatro") == true )
				Console.WriteLine("El elemento existe");
			else
				Console.WriteLine("El elemento NO existe");
			
			Console.ReadKey(true);
		}
	}
}