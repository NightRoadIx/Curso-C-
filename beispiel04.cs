using System;

public class Program
{
	public static void Main()
	{
		int i;
		
		// Ciclo while()
		// El cual piensa antes de hacer
		// se ejecuta mientras la condición sea verdadera
		i = 0;
		while(i < 5)
		{
			Console.WriteLine(i);
			i++;	// No olvidar modificar la variable de la condición
		}
		
		Console.WriteLine("\n");
		
		// Ciclo do - while()
		// El cual hace (al menos una vez) y luego piensa
		i = 0;
		do
		{
			Console.WriteLine(i);
			i++;
		}
		while(i < 5);
		
		Console.WriteLine("\n");
		
		// Sentencias de salto break y continue
		// Para detener la ejecución de un ciclo se puede utilizar "break"
		i = 0;
		while(i < 10)
		{
			// Cuando i sea igual a 4, terminar con el ciclo
			if(i == 4) break;
			// Tras que i sea 4, esto ya nunca se ejecutará
			Console.WriteLine(i);
			i++;
		}
		
		Console.WriteLine("\n");
		
		// Para evitar la ejecución de líneas en algún momento en
		// particular, pero asegurando que se cumpla con las ejecuciones del ciclo
		// puede utilizarse la sentencia continue
		i = 0;
		while(i < 10)
		{
			// Cuando i sea igual a 4, salta
			if(i == 4)
			{
				i++;	// Como las líneas no se ejcutarán hay que incrementar
				continue;
			}
			// todas las instrucciones por debajo
			Console.WriteLine(i);
			i++;
		}
		
	}
}