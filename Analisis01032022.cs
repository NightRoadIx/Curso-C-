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
		// TODO: Incrementar la cantidad de números de la serie a mostrar
		
		/* VARIABLES GLOBALES */
		// Aquí se crea un arreglo donde se guardarán los valores de la serie
		static uint[] serieFibo = new uint[47];
		
		/* FUNCIONES */
		/// <summary>
		/// Función que permite recibir un número entero positivo.
		/// Impide que el usuario ingrese algo que no cumpla con esa condición
		/// </summary>
		/// <param name="limite"> Valor límite superior del entero positivo (default = 47)</param>
		/// <returns>El valor entero positivo ingresado por el usuario</returns>
		public static uint recibirValIntPos(uint limite = 47)
		{
			// Declarar las variables locales
			uint Nlocal;
			
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
			while((!uint.TryParse(Console.ReadLine(), out Nlocal))
			      || (Nlocal > limite))
				// Este
				Console.Write("Ingrese un entero y positivo: ");
			
			return(Nlocal);
		}
		
		public static void generarFibonacci(uint N)
		{
			uint a, b, c, i;
			for(i = 0, a = 1, b = 0, c = 0; i < N; c = a + b, a = b, b = c, i++)
			{
				// UNDONE: Eliminar mostrar la generación de la serie
				Console.WriteLine("{0} + {1} = {2}", a, b, c);
				serieFibo[i] = c;
			}
		}
		
		/// <summary>
		/// mostrarFibonacci
		/// Sirve para mostrar la serie de Fibonacci
		/// </summary>
		/// <param name="limite"> Límite de la serie (47) </param>
		public static void mostrarFibonacci(uint limite = 47)
		{
			uint i;
			for(i = 0; i < limite; i++)
				Console.Write("{0}, ", serieFibo[i]);
			Console.WriteLine("");
		}
		
		public static void Main(string[] args)
		{
			// Declaración de variables
			uint N;
			
			/*
			 * Aquí va la sección de ingresar valores
			 * */
			N = recibirValIntPos();
			/*
			 * Hay que recordar como funciona el for
			 * for(iniciales; condición_única; operaciones)
			 * */
			generarFibonacci(N);
			
			/* Mostrar la serie */
			mostrarFibonacci(N);
			
			Console.Write("Presione algo antes de salir ");
			Console.ReadKey(true);
		}
	}
}