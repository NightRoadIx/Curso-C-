/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 06/03/2020
 * Time: 10:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace matematicosos
{
	class Program
	{
		public static void Main(string[] args)
		{

			/* MÉTODOS MATEMÁTICOS */
			// La clase Math contiene un par de atributos double
			// el número pi
			Console.WriteLine(Math.PI.ToString());
			// el número e
			Console.WriteLine(Math.E.ToString());
			
			/*
				Por otro lado están todos los métodos de las funciones matemáticas
				-Trigonométricas
				Math.Sin()		Seno
				Math.Cos()		Coseno
				Math.Tan()		Tangente
				Math.Asin()		Arco seno
				Math.Acos()		Arco Coseno
				Math.Atan()		Arco Tangente
				Math.Sinh()		Seno hiperbólico
				Math.Cosh()		Coseno hiperbólico
				Math.Tanh()		Tangente Hiperbólica
				
				-Logarítmicas
				Math.Exp()		Exponencial
				Math.Log(double)	Logaritmo base e (natural)
				Math.Log(double, double base)	Logaritmo en la base especificada
				Math.Log10()	Logaritmo base 10
				
				-Redondeo
				Math.Floor()	Redondeo hacia abajo
				Math.Ceiling()	Redondeo hacia arriba
				Math.Round(double, int)		Redondeo a un número específico de decimales
				Math.Truncate()	Trunca un número para hallar la parte entera
				Math.Sign()		Regresa el valor del signo del número
				Math.Abs()		Obtiene el valor absoluto de un número
				
			*/
			
			/* MÉTODOS RANDOM */
			// Ese necesario crear el objeto de la clase Random
			Random aleat = new Random();
			// El método Next obtiene números aleatorios enteros en un cierto intervalo
			Console.WriteLine(aleat.Next(1,10).ToString());
			// El método NextDouble(), obtiene  números aleatorios en el intervalo [0,1)
			Console.WriteLine(aleat.NextDouble().ToString());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}