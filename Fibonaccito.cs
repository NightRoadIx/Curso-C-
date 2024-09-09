using System;

public class Fibonaccito
{
	public static void Main()
	{
		// FIXME: Colocar una variable como Hardcode
		int n = 7;
		
		// TODO: Crear el código de la serie de Fibonacci
		int a = 0, b = 1, c = 0;
		int[] serie = new int[n];

		for(int i = 0; i < n; i++)
		{
			Console.Write("{0}, ", c);
			c = a + b;
			//Console.Write(c + ", ");
			a = b;
			b = c;
		}
	}
}
