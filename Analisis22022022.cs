/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 22/02/2022
 * Time: 00:00 p. m.
 * 
 */
using System;

namespace Fibonachi
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Declaración de variables
			// UNDONE: Quitar la parte del hardcode
			uint N = 9; // hardcode
			uint a, b, c, i;
			// TODO: Implementar la funcionalidad aquí
			
			/*
			 * Aquí va la sección de ingresar valores
			 * */
			Console.Write("Ingrese un número entero y positivo: ");
			/*
			 * uint esta funcionando como un "objeto"
			 * este contiene una funcionalidad llamada TryParse
			 * Que intenta convertir los datos de una cadena de texto
			 * a una variable de tipo uint
			 * En esencia es como scanf() en C, solamente que TryParse
			 * retorna un bool indicando si la conversión fue exitosa o no
			 * */
			// TODO: Localizar cuál es el límite máximo que puede tener N
			// esto es, localizar el límite máximo de uint para ponerlo
			// en la condición
			while((!uint.TryParse(Console.ReadLine(), N))&&(N <= 0))
				// Este
				Console.Write("Ingrese un entero y positivo: ");
				
			/*
			 * Hay que recordar como funciona el for
			 * for(iniciales; condición_única; operaciones)
			 * */
			// FIXME: Mostrar correctamente toda la serie de Fibonacci
			// TODO: Montar la serie de Fibonacci en un arreglo
			for(i = 0, a = 0, b = 1, c = 0; i < N; c = a + b, a = b, b = c, i++)
				Console.WriteLine("{0} + {1} = {2}", a, b, c);
			
			Console.Write("Presione algo antes de salir ");
			Console.ReadKey(true);
		}
	}
}