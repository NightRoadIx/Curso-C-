/*
 * Ciclos para el bloquer de control
 * ciclo for 
 * */
using System;
					
public class Program
{
	public static void Main()
	{
		int i;
		
		/*
		 * while(true) 
		 * {
		 * 		if(condición)
		 * 			break;
		 * }
		 * */
		
		// Ciclo for, utilizado para hacer ciclos cuyo número esta bien definido
		// la ejecución es la siguiente:
		// for(inicio_de_variables, inicio_var01; condición; operaciones, operación01, operación02)
		// {
		//		Cuerpo del for
		// }
		// La ejecución es inicio_de_variables (se ejecuta solo una vez)
		// posteriormente se prueba la condición
		// luego el Cuerpo del for
		// finalmente las operaciones y se regresa a condición y así sucesivamente
		for(i = 0; i < 10; i++)
		{
			Console.WriteLine(i);
		}
		
		// Por otro lado, si el for realiza solo operaciones, se puede colocar todo
		// dentro de la expresión
		// Por ejemplo para sumar los números del 0 al 9
		int total;
		for(i = 0, total = 0; i < 10; total += i, i++);
		// Es absolutamente importante colocar un ";" ya que no hay instrucciones debajo
		
		Console.WriteLine("El valor es {0}", total);
		
		
		// Sentencia foreach
		// Es una sentencia de ciclo adicional a las existentes en C-ANSI
		// la cual es utilizada para recorrer un arreglo
		// Su uso es foreach(tipo nombreVariable in nombreArreglo)
		string[] frutas = {"manzana", "naranja", "uva", "cereza"};
		foreach(string c in frutas)
			Console.WriteLine(c);
		
		Console.ReadKey();
	}
}
