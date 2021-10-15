/*
 * Programa que obtiene la serie de Fibonacci
 * 0,1,1,2,3,5,8,13,21,34,55,89,...
 * El usuario ingresa cuantos números desea observar
 * y este muestra la serie en pantalla
 * Se permite solamente ingresar al usuario números enteros y positivos
 * */
 
/* Librerías */
using System;

/* Espacio de nombres */
namespace programa
{
	/* Clase Fibonacci */
	public class Fibonacci
	{
		/* ATRIBUTOS */
		// private int[] arreglo = {0, 1, 2, 3, 4, 5, 6};
		private int[] arreglo = new int[46];   // int arreglo[46];
		private int n;
		
		/* MÉTODOS */
		/* Constructor */
		public Fibonacci()
		{
			// Inicia los valores a 0
			this.n = 0;
			for(int k = 0; k < 46; k++)
				this.arreglo[k] = 0;
		}
		
		/* Setter n */
		public void setN(int num)
		{
			this.n = num;
		}
		/* Getter n */
		public int getN()
		{
			return this.n;
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
        	Console.Write("Ingrese el número de elementos de la serie: ");
        	while((!Int32.TryParse(Console.ReadLine(), out this.n))||( (this.n <= nim)||(this.n > xam) ))
        	{
        		Console.ForegroundColor = ConsoleColor.Red;
        		Console.WriteLine("Valor inválido, vuelva a ingresarlo");
        		Console.ResetColor();
        	}
    	}
		
    	/* Función calcularFibonacci
    	 * Permite realizar el cálculo de la serie de Fibonacci
    	 * hasta n números
    	 * */
    	public void calcularFibonacci()
    	{
    		for(int k = 0, a = 1, b = 0, c = 0; k < this.n; c = a + b, a = b, b = c, k++)
    			this.arreglo[k] = c;
    	}
    	
    	/* Función verFibonacci
    	 * Observar los elementos de la serie de Fibonacci calculados
    	 * y almacenados en un vector o arreglo
    	 * Recibe
    	 * n:		Cantidad de números de la serie
    	 * */		
    	public void verFibonacci()
    	{
        	for(int k = 0; k < this.n; k++)
        		Console.Write("{0}, ", this.arreglo[k]);    		
    	}
	}
	
	/* Clase Programa */
    class Program
    {
    	
    	/* Función principal */
    	public static void Main()
        {
    		char opc;
    		
    		// Instanciar un objeto
    		// aquí se ocupa el constructor, inicia los valores a cero
    		Fibonacci serie = new Fibonacci();
    		
    		/* Prueba */
    		Console.WriteLine("Números de la serie: {0}", serie.getN() );
    		// Para ver todos los números de la serie se coloca n como 46
    		serie.setN(46);
    		serie.verFibonacci();
    		serie.setN(0);
    		/* Fin Prueba */
    		
    		do
    		{
	    		Console.ForegroundColor = ConsoleColor.Yellow;
	    		Console.WriteLine("\n<-*-*-*- SERIE DE FIBONACCI -*-*-*->");
	    		// Pedir valores de la serie de Fibonacci
	    		Console.ForegroundColor = ConsoleColor.White;
	    		serie.recibirValor(0, 46);
	    		
	    		// Calcular la serie
	    		serie.calcularFibonacci();
	    		
	    		Console.ForegroundColor = ConsoleColor.Gray;
	    		// Mostrar la serie calculada
	    		serie.verFibonacci();
	    	
	    		Console.ForegroundColor = ConsoleColor.White;
	    		Console.Write("\nDesea ver otra serie [s/n]?: ");
	    		// Recuerden aquí se lee solamente un caracter
	    		opc = Console.ReadKey().KeyChar;
    		}
    		while( Char.ToLower(opc) != 'n' ); // Esto seguirá mientras lo que se presione sería diferente de 'n'
    		
    		Console.ForegroundColor = ConsoleColor.Blue;
        	Console.WriteLine("\nPresione una tecla para salir");
        	Console.ReadKey(true);
        	
        }
    }
}
