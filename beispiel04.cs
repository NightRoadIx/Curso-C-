/*
 * Sentencias de control
 * para la generación de ciclos
 * */
using System;

public class Program 
{
	public static void Main()
	{
		// unsigned int i;  // Entero sin signo (+) 0b11111111 => 0 a 255
		byte ochoBits; // -127 a +127		0b01111111 
		// 2123 = 2*10^3 + 1*10^2 + 2*10^1 + 3*10^0		
		int i;
		
		// Ciclo while()
		// El cual piensa antes de hacer
		// se ejecuta mientras la condición sea verdadera
		i = 0;
		while(i < 5)  //true se ejecuta, false se detiene
		{
			Console.WriteLine(i);
			i++;	// No olvidar modificar la variable de la condición
		}
		/* while(true)
		{
			Console.WriteLine(i);
			i++;	// No olvidar modificar la variable de la condición
			if(i > 5) // para ciclos infinitos
				break;
		} */
				
		Console.WriteLine("\n");
		
		// Ciclo do - while()
		// El cual hace (al menos una vez) y luego piensa
		i = 0;   // i = 6;
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
				i++;	// Como las líneas no se ejecutarán hay que incrementar
				continue;
			}
			// todas las instrucciones por debajo
			Console.WriteLine(i);
			i++;
		}
		
		Console.ReadKey();
	}
}
