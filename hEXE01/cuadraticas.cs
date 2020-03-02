/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 19/02/2020
 * Time: 10:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fig_Aster
{
	class Program
	{
		static double Ingresar(string msj)
		{
			string tmp;
			double num;
			do
			{
				Console.WriteLine(msj);
				tmp = Console.ReadLine();
				if (double.TryParse(tmp, out num)) break;
			} while(true);
			return num;
		}
		
		public static void Main(string[] args)
		{
			double a, b, c, disc;
			
			// Ingresar los coeficientes
			a = Ingresar("Ingrese el valor del coeficiente a: ");
			b = Ingresar("Ingrese el valor del coeficiente b: ");
			c = Ingresar("Ingrese el valor del coeficiente c: ");
			
			// b^2 - 4ac
			// Calcular de acuerdo al discriminante las soluciones
			disc = Math.Pow(b, 2) - 4*a*c;
			Console.WriteLine("Soluciones:");
			if( disc >= 0 )		// Raíces reales
			{				
				Console.WriteLine("x1 = {0:N2}", (-b + Math.Sqrt(disc)) / (2*a));
				Console.WriteLine("x2 = {0:N2}", (-b - Math.Sqrt(disc)) / (2*a));
			}
			else		// Raíces complejas
			{
				Console.WriteLine("x1 = {0:N2} + {1:N2}i", (-b) / (2*a), Math.Sqrt(Math.Abs(disc))/(2*a));
				Console.WriteLine("x2 = {0:N2} - {1:N2}i", (-b) / (2*a), Math.Sqrt(Math.Abs(disc))/(2*a));
			}
			
            Console.ReadKey(true);
		}
	}
}