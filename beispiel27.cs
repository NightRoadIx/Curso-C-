using System;
using System.Threading;

namespace multithreading
{
	class Program
	{
		public static void metodo1()
		{
			Console.WriteLine("Método 1 ha iniciado");
			// Esto imprime los números del 0 al 10
			for(int i = 0; i <= 10; i++)
			{
				Console.WriteLine("Método1 es: {0}", i);
				// cuando el valor de i sea igual a 5, el método se "duerme"
				// por 6 segundos y después continua
				// Esto va a simular un proceso pesado
				if(i == 5)
				{
					Console.WriteLine("Comenzó el proceso difícil en Método 1");
					Thread.Sleep(6000);
				}
			}
			Console.WriteLine("Método 1 ha finalizado");
		}
		
		// Método estático #2
		public static void metodo2()
		{
			Console.WriteLine("Método 2 ha iniciado");
			// Imprime los números del 0 al 10
			for(int j=0; j <= 10; j++)
				Console.WriteLine("Método2 es: {0}", j);
			Console.WriteLine("Método 2 ha finalizado");
		}
		
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			Thread thr1 = new Thread(metodo1);
			Thread thr2 = new Thread(metodo2);
			
			thr1.Priority = ThreadPriority.Lowest;
			thr2.Priority = ThreadPriority.Highest;
			
			thr1.Start();
			thr2.Start();
			
			Console.ReadKey(true);
		}
	}
}