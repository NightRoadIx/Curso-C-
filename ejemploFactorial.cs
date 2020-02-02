/*
 Obtención del factorial de un número
*/
using System;
					
public class Program
{
	public static void Main()
	{
		// Variables a utilizar
		// num 	 -	número a obtener faxtorial [int]
		// i	 -	contador [int]
		// result-	resultado (num!) [long] para almacenar números grandes
		int num, i;
		long result;
		
		// Pedir que número se desea calcular el factorial
		Console.WriteLine("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		// Cuando se va a realizar multiplicaciones sucesivas, se inicia 
		// una variable donde guardar el resultado (acumulador) a 1 (1 x cualquier número, da el mismo número)
		// Luego el contador irá de 1 hasta el número a calcular
		// y se acumulan las multiplicaciones
		for(i = 1, result = 1; i <= num; result *= i, i++);
		Console.WriteLine("El factorial de {0} es {1}", num, result);		
		
	}
}