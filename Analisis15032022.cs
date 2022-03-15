using System;

namespace separaNumeros2
{
	class Program
	{
		public static long leerLong()
		{
			long num;
			// Ingresar un número entero (long)
			// TODO: Limitar a positivos y máximo que soporte el long
			Console.WriteLine("Ingresar un número entero para descomponer: ");
			while(!long.TryParse(Console.ReadLine(), out num))
				Console.Write("Un número entero no seas...> ");
			return num;
		}
		
		public static void Main(string[] args)
		{
			// TODO: Separar un número en sus componentes
			// 1492 = 1000 + 400 + 90 + 2
			
			/* 
			 * 1492 / 10^3 = 1 * 10^3 = 1000
			 * 1492 % 10^3 = 492
			 * ------------------------------
			 * 492 / 10^2 = 4 * 10^2 = 400
			 * 492 % 10^2 = 92      
			 * ------------------------------
			 * 92 / 10^1 = 9 * 10^1 = 90
			 * 92 % 10^1 = 2
			 * ------------------------------
			 * 2 / 10^0 = 2 * 10^0 = 2
			 * 2 % 10^0 = 0  
			 * */
			
			// Variables
			int n;			// 32 bits 
			long numero;	// 64 bits
			
			numero = leerLong();
			
			// Colocar el algoritmo
			for(n = numero.ToString().Length - 1; n >= 0; numero %= (long)Math.Pow(10, n), n--)
				// numero / 10^n
				// int digito = (int)(numero / Math.Pow(10, n)); 
				// digito * 10^n
				// TODO: Quitar el último '+' al mostrar los componentes numéricos
				Console.Write("{0} + ", (int)(numero / Math.Pow(10, n)) * Math.Pow(10, n));  
				// numero %= (long)Math.Pow(10, n);
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
	}
}