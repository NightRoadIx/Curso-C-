/*
 * Programa que obtiene la serie de Fibonacci
 * 0,1,1,2,3,5,8,13,21,34,55,89,...
 * El usuario ingresa cuantos números desea observar
 * y este muestra la serie en pantalla
 * Se permite solamente ingresar al usuario números enteros y positivos
 * */
// Librerías
using System;

/* Espacio de nombres */
namespace fibonino
{
	/* Clase Program */
	class Program
	{
		public static void Main(string[] args)
		{
			// Cantidad de números a mostrar de la serie de Fibonacci
			int N;
			// Datos para obtener la serie de Fibonacci
			int a, b, c, k;
			
			Console.WriteLine("Hágame el favor de indicarme cuántos " +
			                  "números de la otrora serie de Fibonacci " +
			                  "desea usted amable usuario observar en el " +
			                  "monitor de su computadora: ");
			while((!Int32.TryParse(Console.ReadLine(), out N))||( N < 0 ))
				Console.WriteLine("Mi muy estimado usuario, el valor " + 
				                  "{0} que ha, con su venia, ingresado, " +
				                  "NO es correcto, si es su menester, " +
				                  "hágame el inmenso favor de ingresar un " +
				                  "número, entero y positivo", N);
			
			// UNDONE: Eliminar esta prueba
			Console.WriteLine("El usuario ha ingresado {0}", N);
			// La serie de Fibonacci
			for(k = 0, a = 1, b = 0, c = 0; k < N; c = a + b, a = b, b = c, k++)
				Console.Write("{0}, ", c);
			
			Console.Write("\nPresione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}