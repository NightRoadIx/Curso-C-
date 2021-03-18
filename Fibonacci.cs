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
	/* Clase Programa */
    class Program
    {
    	
    	/* VARIABLES GLOBALES */
    	static int[] arreglo = new int[46];		// |int0|int1|int2|int3|int4|int5|...|int45|
    	
    	/* FUNCIONES AQUÍ */
    	/* Funciones */
    	/*
    	 * Funcion recibirValor
    	 * Permite la recepción de un número entero en un intervalo [nim, xam]
    	 * Recibe
    	 * nim:		Valor mínimo del intervalo de entrada
    	 * xam:		Valor máximo del intervalo de entrada
    	 * 
    	 * Regresa
    	 * n:		Valor ingresado por el usuario
    	 * */
    	public static int recibirValor(int nim, int xam)
    	{
    		// Variables locales
    		int n;
    		
        	Console.WriteLine("-- Serie de Fibonacci --");
        	Console.Write("Ingrese el numero de elementos de la serie: ");
        	while((!Int32.TryParse(Console.ReadLine(), out n))||( (n <= nim)||(n > xam) ))
        		Console.WriteLine("Valor inválido, vuelva a ingresarlo");
        	
        	return n;
    	}
    	
    	/* Función calcularFibonacci
    	 * Permite realizar el cálculo de la serie de Fibonacci
    	 * hasta n números
    	 * Recibe
    	 * n:		Cantidad de números de la serie
    	 * 
    	 * Regresa
    	 * Ningún valor
    	 * */
    	public static void calcularFibonacci(int n)
    	{
    		int k, a, b, c;
    		for(k = 0, a = 1, b = 0, c = 0; k < n; c = a + b, a = b, b = c, k++)
    			arreglo[k] = c;
    	}
    	
    	/* Función verFibonacci
    	 * Observar los elementos de la serie de Fibonacci calculados
    	 * y almacenados en un vector o arreglo
    	 * Recibe
    	 * n:		Cantidad de números de la serie
    	 * 
    	 * Regresa
    	 * Ningún valor
    	 * */		
    	public static void verFibonacci(int n)
    	{
    		int k;
        	for(k = 0; k < n; k++)
        		Console.Write("{0}, ", arreglo[k]);    		
    	}
    	
    	/* Función principal */
    	public static void Main()
        {
        	// Variables locales
        	int numeroEntrada;
        	
        	// Ingresar datos
        	numeroEntrada = recibirValor(0,46);
        	
        	// Obtener serie
        	calcularFibonacci(numeroEntrada);
        	
        	// Ver los elementos del arreglo
        	verFibonacci(numeroEntrada);
        	
        	Console.WriteLine("\nPresione una tecla para salir");
        	Console.ReadKey(true);
        }
    }
}