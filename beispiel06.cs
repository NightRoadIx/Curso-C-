/*
 * Arreglos
 * Bloque de Memoria
 * 
 * | Espacio de memoria para un Entero 32 bits | => int 
 * 
 * Arreglos espacio en memoria del tamaño del tipo del variable
 * | int32 espacio 01 | [0] => int arreglo
 * | int32 espacio 02 | [1] ...
 * 
 * */
using System;

namespace pruebas
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// Genear un vector con valores ya definidos
			int[] misNumeros = {0,1,2,3,4,5,6,7,8,9};
			// | 1,2,3,4,5,6,7,8,9 |
			// Generar un vector con cierta cantidad de espacios disponibles
			// se debe usar la palabra new y el tipo de dato, de la forma:
			// int[] nombre = new int[TAMAÑO];
			
			// C-ANSI:
			// int vector[10];
			// Sin embargo, es posible usar asignación dinámica de espacios
			Console.Write("Ingresar tamaño del vector: ");
			int k = Convert.ToInt32(Console.ReadLine());
			int[] vector = new int[k];
			
			// Así ya se pueden ingresar valores en el vector generado
			// la propiedad .Length del vector proporciona el número
			// total de elementos en el arreglo
			for(k = 0; k < vector.Length; k++)
			{
				Console.Write("Elemento {0}: ", k);
				vector[k] = Convert.ToInt32(Console.ReadLine());
			}
			
			// Recorrer el vector para mostrarlo
			foreach (int tmp in vector)
				Console.Write(" {0} ", tmp);
			
			// Matrices regulares
			/*
			 * | 0 0 0 |
			 * | 0 0 0 |
			 * | 0 0 0 |
			 * */
			// Se declaran, colocando una coma por cada dimensión
			int[,] matriz = new int[3,3];
			
			/* PROPIEDADES DE LOS VECTORES */
			// Tamaño de los vectores
			Console.WriteLine( misNumeros.Length );
			// o de las matrices, ambos proporcionan el número de elementos
			Console.WriteLine( matriz.Length );
			
			// Número de dimensiones de la matriz
			Console.WriteLine( matriz.Rank );
			
			Console.ReadKey(true);
		}
	}
}
