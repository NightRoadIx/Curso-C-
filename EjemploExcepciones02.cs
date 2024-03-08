using System;

// Para iniciar el programa
public class Program
{
	// Función principal
	public static void Main()
	{
		try
		{
			// Convertir una cadena a entero
			int numero = int.Parse("Hola mundo");

			// Dividir entre cero
			int resultado = numero / 0;

			// Código que nunca se ejecutará debido a las excepciones anteriores
			Console.WriteLine("Resultado: " + resultado);
		}
		// Excepción cuando se intenta convertir un entero
		catch (FormatException ex)
		{
			Console.WriteLine("Error al convertir a entero: " + ex.Message);
		}
		// Excepción al dividir entre 0
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Error al dividir por cero: " + ex.Message);
		}
		// Código a ejecutar pase o no alguna excepción
		finally
		{
			Console.WriteLine("Código finally ejecutado");
		}
}