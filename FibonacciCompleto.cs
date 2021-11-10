/*
 * Programa que obtiene la serie de Fibonacci
 * 0,1,1,2,3,5,8,13,21,34,55,89,...
 * El usuario ingresa cuantos números desea observar
 * y este muestra la serie en pantalla
 * Se permite solamente ingresar al usuario números enteros y positivos
 * */
 
/* Librerías */
using System;
using System.IO;
using System.Collections.Generic;

/* Espacio de nombres */
namespace programa
{	
	/* Clase Fibonacci */
	public class Fibonacci
	{
		/* ATRIBUTOS */
		private List<int> arregloF = new List<int>();
		private int n;
		
		/* MÉTODOS */
		/* Constructor */
		public Fibonacci()
		{
			// Inicia el contador de valores a 0
			this.n = 0;
			for(int k = 0; k < 46; k++)
				this.arregloF.Add(0);
		}
		
		// Getters, setters para n
		public int N
		{
			get; set;
		}
		
    	/*
    	 * Funcion recibirValor
    	 * Permite la recepción de un número entero en un intervalo [nim, xam]
    	 * Recibe
    	 * nim:		Valor mínimo del intervalo de entrada
    	 * xam:		Valor máximo del intervalo de entrada
    	 * */
    	public void recibirValor(int nim, int xam)
    	{
    		Console.ForegroundColor = ConsoleColor.Gray;
        	Console.Write("\nIngrese el número de elementos de la serie: ");
        	while((!Int32.TryParse(Console.ReadLine(), out this.n))||( (this.n <= nim)||(this.n > xam) ))
        	{
        		Console.ForegroundColor = ConsoleColor.Red;
        		Console.Write("Valor inválido, vuelva a ingresarlo: ");
        		Console.ForegroundColor = ConsoleColor.Gray;
        	}
    	}
		
    	/* Función calcularFibonacci
    	 * Permite realizar el cálculo de la serie de Fibonacci
    	 * hasta n números
    	 * */
    	public void calcularFibonacci()
    	{
    		for(int k = 0, a = 1, b = 0, c = 0; k < this.n; c = a + b, a = b, b = c, k++)
    			this.arregloF[k] = c;
    	}
    	
    	/* Función verFibonacci
    	 * Observar los elementos de la serie de Fibonacci calculados
    	 * y almacenados en un vector o arreglo
    	 * */		
    	public void verFibonacci()
    	{
    		Console.ForegroundColor = ConsoleColor.White;
    		for(int tmp = 0; tmp < this.n; tmp++)
    			Console.Write("{0}, ", this.arregloF[tmp]);
    		Console.ForegroundColor = ConsoleColor.Gray;
    	}
	}
	
	/* Clase Programa */
    class Program
    {
    	/* Función para generar un archivo log */
    	public static void Log(string mensaje)
    	{
    		// Se crea el texto a ingresar
    		string msj = "Entrada del log : \n" +
    			"{" + DateTime.Now.ToLongTimeString() + "}" +
    			"{" + DateTime.Now.ToLongDateString() + "}\n" +
    			mensaje + "\n- - - - - - - - - - - - -\n";
    		File.AppendAllText("logFibonacci.txt", msj);
    	}
    	
    	/* Función principal */
    	public static void Main()
        {
    		// Instanciar un objeto
    		// aquí se ocupa el constructor, inicia los valores a cero
    		Fibonacci serie = new Fibonacci();    		    		
    		
    		Console.ForegroundColor = ConsoleColor.Yellow;
    		Console.WriteLine("\n<-*-*-*- SERIE DE FIBONACCI -*-*-*->");
    		
    		do
    		{
	    		// Pedir valores de la serie de Fibonacci
	    		serie.recibirValor(0, 50);
	    		
	    		// Calcular la serie
	    		// Aquí se puede generar una excepción si se sobrepasa los límites de almacenamiento del entero
	    		try
	    		{
	    			serie.calcularFibonacci();
	    			// Mostrar la serie calculada
		    		serie.verFibonacci();
	    		}
	    		catch(Exception e)
	    		{
	    			// El usuario no notará que hubo un error, solamente se le mostrará un mensaje de que no 
	    			// es posible calcular la serie hasta dicho valor
	    			Console.ForegroundColor = ConsoleColor.Red;
	    			Console.Write("\nNo pueden ser calculados más números de la serie");
	    			Console.ForegroundColor = ConsoleColor.Gray;
	    			// Pero se guarda la información del error en un archivo de texto
	    			Log(e.Message);
	    		}
	    		
	    		// Pedir si se desea calcular otra cantidad de números de la serie
	    		Console.Write("\nCalcular otra serie? (s/n) ");
    		}
    		while(Console.ReadKey().Key == ConsoleKey.S);
        	
    		// Terminar el programa
    		Console.ForegroundColor = ConsoleColor.Magenta;
        	Console.WriteLine("\nPresione una tecla para salir");
        	Console.ReadKey(true);
        }
    }
}