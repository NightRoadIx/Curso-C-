// Añadir librería de System, que contiene casi todo
using System;

// Espacio de nombres
namespace Fibonachi
{
	// Clase Program, que contendrá el programa (valga la rebuznancia)
	class Program
	{
		// Función principal (main) desde donde arranca el programa
		public static void Main(string[] args)
		{
			// Declaración de variables
			uint N = 9; // hardcode para asignación de datos a una variable
			uint a, b, c, i;
			
			// El for se compone de:
			// for(inicio_de_variables; condición; operaciones)
			for(i = 0, a = 0, b = 1, c = 0; i < N; c = a + b, a = b, b = c, i++)
				Console.WriteLine("{0} + {1} = {2}", a, b, c);
			
			Console.Write("Presione algo antes de salir ");
			Console.ReadKey(true);
		}
	}
}