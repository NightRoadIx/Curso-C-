// Esto sustituye al #include <> en C
// Permite usar atributos y métodos del sistema
using System;

// Para iniciar el programa
public class Program
{
	// Función principal
	public static void Main()
	{
		
		/*
			Tipos de variables
		*/
		// Valor booleano, solo toma dos valores, true o false (1 bit)
		bool miBoleano = true;
		// Variable caracter (8 bits)
		char caracter = 'c';
		// Variable entero (32 bits)
		int miNum = 15;
		// Variable entero (64 bits)
		long otroNum = 15642;
		// Variable decimal (32 bits), se requiere colocar una 'f' al final del número
		float numDecimal = 3.1416f;
		// Variable decimal (64 bits)
		double otroDecimal = 3.1415926534;
		// Variable cadena de caracteres (Dependiendo de la cantidad de caracteres)
		string nombre = "Juan Nepomuceno";
		
		/*
			Método para imprimir en pantalla tanto cadenas de texto, como variables
			Console.WriteLine()
		*/
		Console.WriteLine("Estas son las variables");
		Console.WriteLine(nombre);
		Console.WriteLine(miNum);
		Console.WriteLine(miBoleano);
		// Para mostrar una cadena de texto y una variable
		Console.WriteLine("Aquí van " + nombre);
		// Para mostrar tanto cadenas de texto como variables se puede realizar
		Console.WriteLine("Aquí van {0} y un número {1}", nombre, miNum);
		
		/*
			Función para ingresar datos
			Console.ReadLine()
		*/
		Console.WriteLine("Ingrese su nombre: ");
		// C# permite decalrar variables a lo largo del código, sin embargo no es aconsejable
		string nombreUsuario = Console.ReadLine();
		Console.WriteLine("Nombre: " + nombreUsuario);
		Console.WriteLine("Ingrese su edad: ");
		/* 
			Sin embargo, lo que regresa esta función es una cadena de texto (string)
			Por lo que es necesario usar un método para convertir
			Convert.ToBoolean() 
			Convert.ToDouble() 
			Convert.ToString() 
			Convert.ToInt32()
			Convert.ToInt64()
		*/
		int edad = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Edad: " + edad);
		
		
	}
}