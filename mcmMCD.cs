/*
 * Created by SharpDevelop.
 * User: NightRoadIx
 * Date: 17/09/2021
 * Time: 66:66
 * 
 */
 
/*
 * El programa recibe 2 números enteros y positivos y localiza el
 * máximo común divisor y el mínimo común multiplo
 * */
using System;

namespace minima
{
	class Program
	{
		public static int recibirValorEntero(string msj1, int nim = 0, int xam = Int32.MaxValue)
		{
			// Variables locales
			int n;
			
			// Cambiar el color del texto
			Console.ForegroundColor = ConsoleColor.Green;
			// 	Mostrar el mensaje de entrada 
			Console.Write(msj1);
			Console.ForegroundColor = ConsoleColor.Gray;
			// Ciclo para solamente ingresar un número entero en un intervalo [nim, xam)
			while( (!Int32.TryParse(Console.ReadLine(), out n))||( (n <= nim)||(n > xam) ) )
			{
				Console.ForegroundColor = ConsoleColor.Red;
				// Colocar un mensaje de error
				Console.Write("-Valor inválido, vuelva a ingresarlo--> ");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			
			// Regresa el valor del entero ingresado
			return n;
		}
		
		public static void Main(string[] args)
		{
			// Variables locales
			int a, b, tmp, res, a1, b1;
			
			// Cambiar el color de fondo
			//Console.BackgroundColor = ConsoleColor.White;
			//Console.Clear();
			
			// Cambiar el nombre de la ventana
			Console.Title = "Mi ventanita del MCD y mcm";
			
			// Ingresar los valores de los números
			a = recibirValorEntero("Ingresar el número a: "); a1 = a;
			b = recibirValorEntero("Ingresar el número b: "); b1 = b;
			
			// Dado que el algoritmo requiere que b > a, se realiza este movimiento
			if(a > b){ tmp = b; b = a; a = tmp; }
			
			/* Algoritmo de Euclídes */
			do
			{
				// Obtener el residuo
				res = b % a;
				// UNDONE: Tabla que muestra el proceso de divisiones
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("{0}\t{1}\t{2}", a, b, res);
				// Realizar las modificaciones de las variables
				b = a;
				a = res;
			}
			while(res != 0);
			
			// Mostrar los resultados
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("MCD({0},{1}) = {2}", a1, b1, b);
			Console.WriteLine("mcm({0},{1}) = {2}", a1, b1, (a1*b1)/b);
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
	}
}