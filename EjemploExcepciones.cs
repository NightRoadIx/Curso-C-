// Esto sustituye al #include <> en C
// Permite usar atributos y métodos del sistema
using System;

// Para iniciar el programa
public class Program
{
	// Función principal
	public static void Main()
	{
		int numero = 5, i;
		/*
		for(i = -10; i <= 10; i++) {
			if(i == 0)
				continue;
			Console.WriteLine(numero / i);
		}
		*/
		for(i = -10; i <= 10; i++) {
			try
			{
				// Intenta ejecutar estas instrucciones
				// 	que pueden generar error
				Console.WriteLine(numero / i);
			}
			catch(DivideByZeroException ex)
			{
				// Colocar como se va a manejar esa Excepción
				Console.WriteLine("Injinito");
				Console.WriteLine("El error es: " + ex.ToString());
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.WriteLine("---");
			}
				
		}			
	}
}
