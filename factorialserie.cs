using System;

public class FactorialSerie
{
    public static double Factorial(int n)
    {
        double resultado = 1;
        for (int i = 0; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    public static double CalcularSerie(int N)
    {
        double suma = 0;

        for (int n = 0; n < N; n++)
        {
            suma += 1 / Factorial(n);
        }

        return suma;
    }

    public static void Main()
    {
        Console.WriteLine("Programa para calcular la suma de la serie 1/n! desde n = 0 hasta N.");

        Console.Write("Ingrese el valor de N: ");
        int N = Console.ReadLine();

        double resultado = CalcularSerie(N);
        Console.WriteLine("\nEl resultado de la serie 1/n! desde n = 0 hasta {1} es: {0}");
	}
}
