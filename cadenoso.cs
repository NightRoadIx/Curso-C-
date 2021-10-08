/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 07/10/2021
 * Time: 06:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cadenoso2
{
	class Program
	{
		// y = f(w, x, z, t)
		public static void Main(string[] args)
		{
			bool buleano = true;		// 1 bit *
			char caracter = 'a';		// 8 bits   
			int entero = -666;			// 32 bits *
			uint uentero = 666;			// 32 bits *
			long largo = 234567898765;	// 64 bits
			float flotante = 3.1416f;	// 32 bits
			double doble = 3.141592653489;	// 64 bits
			string cadena = "Soy una cadena"; // Depende de la longitud
			
			int valor;
			// Aquí se intenta convertir a un entero de 32 bits usando el objeto Int32
			bool valorBuleano = Int32.TryParse(cadena, out valor);
			// También nos permite ver el tamaño o número máximo que puede guardar
			Console.WriteLine(Int16.MaxValue);
			Console.WriteLine(Int32.MaxValue);
			Console.WriteLine(Int64.MaxValue);
			
			// Con esto pueden procesar una cadena de texto
			string prueba = Console.ReadLine();
			Console.WriteLine(prueba[0]);
			Console.WriteLine(prueba.Length);
			
			// Determinar si uno de los caracteres es un dígito
			Console.WriteLine( Char.IsDigit(prueba[0]) );
			
			// y recorrer a través de la cadena
			foreach(char tmp in prueba)
			{
				Console.Write(tmp + " - ");
			}
						
			
			Console.Write("Presione cualquier tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}
