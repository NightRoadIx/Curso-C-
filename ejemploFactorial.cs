/*
 Obtención del factorial de un número
*/
using System;
					
public class Program
{
	public static void Main()
	{
		/*
			Programa para calcular el factorial de un número
			El factorial de un número está definido como:
			n! = n*(n-1)*(n-2)*...*1

			Definiendo 0! = 1
		*/
		// Variables a utilizar
		// num 	 -	número a obtener factorial [int]
		// i	 -	contador [int]
		// result-	resultado (num!) [long] para almacenar números grandes
		int num, i;
		long result;
		
		// Pedir que número se desea calcular el factorial
		Console.WriteLine("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		// Cuando se va a realizar multiplicaciones sucesivas, se inicia 
		// una variable donde guardar el resultado (acumulador) a 1 (1 x cualquier número, da el mismo número)
		// A esto se le suele llamar neutro multiplicativo
		// Luego el contador irá de 1 hasta el número a calcular
		// y se acumulan las multiplicaciones
		// La instrucción for, ingresa y toma la primera parte
		// antes del ;, luego revisa si la condición es verdadera
		// y si lo es, ejecuta el cuerpo del for, en caso que este
		// no contenga nada, o al finalizar todas las instrucciones
		// ejecuta las operaciones que se encuentran tras la condición
		// Repitiendo si la condición es verdadera
		// Colocar el resultado result en 1, permite obtener
		// la definición de 0!
		for(i = 1, result = 1; i <= num; result *= i, i++);
		Console.WriteLine("El factorial de {0} es {1}", num, result);
	}
}
