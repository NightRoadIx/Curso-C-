using System;

public class Fibonaccito
{
	public static void Main()
	{
		// FIXME: Colocar una variable como Hardcode
		// REVIEW: Verificar que ambas formas funcionen
		// con varios tipos de valores (como 0 o 1)
		int n = 7;
		
		// TODO: Crear el código de la serie de Fibonacci
		int a = 0, b = 1, c = 0;
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
