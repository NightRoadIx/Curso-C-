using System;

/// <summary>
/// Obtiene un número entero ingresado por el usuario que se encuentra dentro del intervalo [a, b].
/// </summary>
/// <param name="a">El valor mínimo del intervalo.</param>
/// <param name="b">El valor máximo del intervalo.</param>
/// <returns>El número entero ingresado por el usuario que se encuentra dentro del intervalo especificado.</returns>
public class Restricto
{
	// * * * * * * * ATRIBUTOS * * * * * * *
	
	// * * * * * * * MÉTODOS * * * * * * *
	// Método especial Constructor
	// Mismo nombre de la clase
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

public class Fibonaccito
{
	public static void Main()
	{
		// Instanciar un objeto Restricto
		// para colocar las restricciones
		// de los datos de entrada
		// Clase objeto = new ConstructorClase();
		Restricto restringir = new Restricto();
		int n = restringir.obtenerEntero(1,20);
		
		// Originalmente, en lenguaje C, no era posible
		// declarar arreglos con un tamaño a partir de una
		// variable, sin embargo, en C# es posible
		// A esto se le conoce como arreglo dinámico
		int[] serie = new int[n];

		// Otra forma de realizar esto es mediante
		// un objeto List, el cual funciona como
		// una lista de datos
		// La declaración requiere del uso de una
		// "wrapper class", que le indica a la lista
		// que objetos va a almacenar
		// La instanciación del objeto es:
		// List<wrapperclass> objeto = new List<wrapperclass>()
		List<int> serie2 = new List<int>();

		/* Serie por arreglos dinámicos */
		Console.WriteLine("\nResolución por arreglos");
		// Revisar que n sea mayor a 1 y 2 para
		// iniciar los valores
		if(n > 2)
		{
			// Se inician los dos primeros valores
			serie[0] = 0; serie[1] = 1;
			// Todo puede calcularse en el for
			// observar que si no se van a colocar 
			// operaciones, se coloca ; al final del for
			for(int i = 2; i < n; serie[i] = serie[i-1] + serie[i-2], i++);
		}

		// Mostrar cuando se calcula con arreglos dinámicos
		// foreach es una instrucción que permite recorrer
		// una colección de datos de manera completa
		// foreach(tipo_dato variable in coleccion)
		foreach(int tmp in serie)
		{	Console.Write(tmp + ", "); }

		/* Resolución por objetos */
		Console.WriteLine("\nResolución por objetos");
		// La ventaja del uso de objetos es que
		// estos, cuentan con ciertos métodos para
		// su manejo
		// Por ejemplo, el médodo Add() para añadir
		// elementos a la lista
		for(int j = 0; j < n; j++)
		{
			if(j == 0) serie2.Add(0);
			else if(j== 1) serie2.Add(1);
			else serie2.Add(serie2[j-1] + serie2[j-2]);
		}
		// Mostrar el resultado
		foreach(int tmp in serie2)
		{	Console.Write(tmp + ", "); }
	}
}
