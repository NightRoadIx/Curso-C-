using System;
using System.Collections.Generic;

/// <summary>
/// Obtiene un número entero ingresado por el usuario que se encuentra dentro del intervalo [a, b].
/// </summary>
/// <param name="a">El valor mínimo del intervalo.</param>
/// <param name="b">El valor máximo del intervalo.</param>
/// <returns>El número entero ingresado por el usuario que se encuentra dentro del intervalo especificado.</returns>
public class Restricto
{
    // * * * * * * * MÉTODOS * * * * * * *
    
    /// <summary>
    /// Constructor de la clase Restricto.
    /// Muestra un mensaje al crear un objeto de la clase.
    /// </summary>    
    public Restricto()
    {
        Console.WriteLine("El objeto Restricto ha sido creado");
    }    
        
    /// <summary>
    /// Obtiene un número entero ingresado por el usuario que se encuentra dentro del intervalo [a, b].
    /// Si el número ingresado no es un entero o no está dentro del rango, solicita al usuario que intente nuevamente.
    /// </summary>
    /// <param name="a">El valor mínimo del intervalo permitido.</param>
    /// <param name="b">El valor máximo del intervalo permitido.</param>
    /// <returns>El número entero ingresado por el usuario que está dentro del intervalo [a, b].</returns>
    public int obtenerEntero(int a, int b)
    {
        int numero;
        
        // Ciclo para pedir el número hasta que esté en el rango [a, b]
        while (true)
        {
            Console.Write($"Ingresa un número entero entre {a} y {b}: ");
            
            // Intentar convertir la entrada a un entero
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verificar si el número está dentro del rango [a, b]
                if (numero >= a && numero <= b)
                    return numero; // Retorna el número si está dentro del rango
                Console.WriteLine($"El número debe estar entre {a} y {b}. Intenta de nuevo.");
            }
            Console.WriteLine("El valor ingresado no es un número entero. Intenta de nuevo.");
        }
    }
}

/// <summary>
/// Clase encargada de calcular y manejar la serie de Fibonacci.
/// </summary>
public class Fibonaccito
{
    // Atributo para almacenar la serie de Fibonacci
    private List<int> serieFibonacci;

    /// <summary>
    /// Constructor de la clase Fibonaccito.
    /// </summary>
    public Fibonaccito()
    {
        // Inicializar la lista que contendrá la serie
        serieFibonacci = new List<int>();
    }

    /// <summary>
    /// Calcula la serie de Fibonacci hasta el enésimo número y almacena los resultados en una lista.
    /// </summary>
    /// <param name="n">El número de términos de la serie que se desean calcular.</param>
    public void CalcularSerie(int n)
    {
        // Limpiar la lista antes de calcular la serie
        serieFibonacci.Clear();

        for (int j = 0; j < n; j++)
        {
            if (j == 0) serieFibonacci.Add(0);   // El primer número de Fibonacci es 0
            else if (j == 1) serieFibonacci.Add(1);  // El segundo número de Fibonacci es 1
            else serieFibonacci.Add(serieFibonacci[j - 1] + serieFibonacci[j - 2]); // Suma de los dos anteriores
        }
    }

    /// <summary>
    /// Muestra la serie de Fibonacci almacenada.
    /// </summary>
    public void MostrarSerie()
    {
        // Mostrar los elementos de la lista
        foreach (int numero in serieFibonacci)
        {
            Console.Write(numero + ", ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        // Instanciar un objeto Restricto para pedir la longitud de la serie
        Restricto restringir = new Restricto();
        int n = restringir.obtenerEntero(1, 20);

        // Instanciar un objeto Fibonaccito
        Fibonaccito fibonaccito = new Fibonaccito();

        // Calcular la serie de Fibonacci hasta el enésimo número
        fibonaccito.CalcularSerie(n);

        // Mostrar la serie de Fibonacci
        Console.WriteLine("La serie de Fibonacci es:");
        fibonaccito.MostrarSerie();
    }
}
