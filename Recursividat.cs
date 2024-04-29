using System;
using System.Collections.Generic;

namespace programa
{
    class Program
    {
        /// <summary>
        /// Función para calcular el factorial de un número.
        /// </summary>
        /// <param name="n">El número para calcular su factorial.</param>
        /// <returns>El factorial del número dado.</returns>
        public static long Factorial(int n)
        {
            if (n == 0)
            {
                // Caso base: el factorial de 0 es 1
                return 1;
            }
            // Caso recursivo: fatorial(n) = n * fatorial(n - 1)
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Función para calcular el término n de la serie de Fibonacci.
        /// </summary>
        /// <param name="n">El índice del término de la serie de Fibonacci.</param>
        /// <returns>El valor del término n de la serie de Fibonacci.</returns>
        public static double Fibonacci(int n)
        {
            if (n <= 1)
            {
                // Caso base: los primeros dos términos de Fibonacci son 1
                return 1;
            }
            // Caso recursivo: fibonacci(n) = fibonacci(n - 1) + fibonacci(n - 2)
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static void Main(string[] args)
        {
            // Imprimir los primeros 100 términos de la serie de Fibonacci
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0}, ", Fibonacci(i));
            }
        }
    }
}
