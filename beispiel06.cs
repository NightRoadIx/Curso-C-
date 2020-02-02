using System;
					
public class Program
{
	// Declaración de un método que recibe argumentos y no retorna nada
	public static void miMetodo(string nombre)
	{
		Console.WriteLine("El nombre es " + nombre);
	}
	
	// Método con un valor de parámetros por defecto
	public static void miMetodo2(string pais = "Suecia")
	{
		Console.WriteLine("Yo soy de " + pais);
	}
	
	// Método que recibe un argumento y regresa un valor
	static int miMetodo3(int x)
	{
		return 5 * x;
	}
	
	public static void Main()
	{
		/* Llamada a los métodos definidos */
		// Mandando argumento, no regresa nada
		miMetodo("Bond, James Bond");
		
		// Recepción de argumentos
		miMetodo2("Islandia");
		miMetodo2();	// No se envía un parámetro, se activa el por defecto
		
		// Recepción de argumentos y retorno de valor
		int valor = miMetodo3(6);
		Console.WriteLine("El resultado es: {0}", valor);
	}
}