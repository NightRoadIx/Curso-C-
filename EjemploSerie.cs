// Esto sustituye al #include <> en C
// Permite usar atributos y métodos del sistema
using System;

namespace Hola
{
	// Para iniciar el programa
	public class EjemploSerie
	{
		/// <summary>
		/// Calcula el factorial de un número entero no negativo.
		/// </summary>
		/// <param name="N">El número entero no negativo del que se desea calcular el factorial.</param>
		/// <returns>Un valor de tipo `long` que representa el factorial de `N`.</returns>
		static long calcularFactorial(int N)
		{
			long result;
			int i;
			for(i = 1, result = 1; i <= N; result *= i, i++);
			return result;
		}

		// Función principal, desde donde se ejecuta el código
		public static void Main()
		{
			int n, i;
			double resultado;

			// Sección para permitir al usuario ingresar un valor
			Console.WriteLine("Ingrese un número: ");
			n = Convert.ToInt32(Console.ReadLine());
			// Aunque se recomienda no declarar variables en medio
			// del programa, C# lo permite, además, los arreglos
			// no son estáticos como en lenguaje C-ANSI, ya que
			// su tamaño puede variar
			double[] vetor = new double[n+1];
			// Calcular la suma del término 1/n! desde 0 hasta N
			for(resultado = 0, i = 0; i <= n; resultado += 1.0/calcularFactorial(i), vetor[i] = resultado , i++);
			Console.WriteLine(resultado);

			// Mostrar la convergencia de la serie
			// Se usa foreach para recorrer un iterable
			// como un arreglo
			foreach(double tmp in vetor)
				Console.WriteLine(tmp);

			// Valor del número e
			Console.WriteLine("Valor de e: {0}", Math.E);

		}
	}
}