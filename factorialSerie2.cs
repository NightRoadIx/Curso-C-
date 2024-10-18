using System;

public class FactorialSerie
{
    /// <summary>
    /// Método para calcular el factorial de un número dado.
    /// </summary>
    /// <param name="n">El número para calcular su factorial.</param>
    /// <returns>El factorial de n.</returns>
    public static double Factorial(int n)
    {
        double resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    /// <summary>
    /// Método para calcular la suma de la serie 1/n! desde n = 0 hasta un valor N proporcionado.
    /// </summary>
    /// <param name="N">El número límite de iteraciones.</param>
    /// <returns>El valor final de la suma de la serie 1/n!.</returns>
    public static double CalcularSerie(int N)
    {
        double suma = 0;

        // Iterar desde n = 0 hasta N
        for (int n = 0; n <= N; n++)
        {
            suma += 1 / Factorial(n); // Sumar 1/n! a la suma total
        }

        return suma; // Devolver la suma total de la serie
    }

    /// <summary>
    /// Método principal que solicita el valor de N al usuario y muestra el valor final de la serie.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Programa para calcular la suma de la serie 1/n! desde n = 0 hasta N.");

        // Solicitar al usuario el valor de N
        Console.Write("Ingrese el valor de N (número de términos a calcular): ");
        int N = int.Parse(Console.ReadLine());

        // Calcular la serie y mostrar el resultado
        double resultado = CalcularSerie(N);
        Console.WriteLine($"\nEl resultado de la serie 1/n! desde n = 0 hasta {N} es: {resultado}");

        Console.ReadKey();
    }
}
