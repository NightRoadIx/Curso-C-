using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace exemples
{
	class Program
	{
		// Atributo
		public static List <string> listaa;
		
		/* Leer un archivo, una base de datos, o datos de la web */ 
		
		private async Task ImprimirCorrecto(int tmpUser)
		{
			Console.WriteLine();
			Console.WriteLine("Imprimircorrecto() Hilo ID - {0} para usuario - {1}", Thread.CurrentThread.ManagedThreadId, tmpUser);
			await Task.Run(() => {
			               	foreach(var item in listaa) {
			               		if(tmpUser == 0)
			               		{
			               			Thread.Sleep(1000);
			               			Console.WriteLine("Usuario: {0} dice - {1} en el hilo ID - {2}", tmpUser, item, Thread.CurrentThread.ManagedThreadId);
			               		}
			               		else
			               		{
			               			Thread.Sleep(500);
			               			Console.WriteLine("Usuario: {0} dice - {1} en el hilo ID - {2}", tmpUser, item, Thread.CurrentThread.ManagedThreadId);
			               		}
			               	}
			               });
		}
		
		private static void Imprimir(int tmpUser)
		{
			Console.WriteLine();
			Console.WriteLine("Imprimir() Hilo ID - {0} para usuario ID - {1}", Thread.CurrentThread.ManagedThreadId, tmpUser);
			new Program().ImprimirCorrecto(tmpUser).Wait();
			Console.WriteLine("Imprimiendo para usuario {0} completo con hilo ID - {1}", tmpUser, Thread.CurrentThread.ManagedThreadId);
		} 
		
		private static void crearHilo(int tmpUser)
		{
			Console.WriteLine();
			Console.WriteLine("CrearHilo() Hilo ID - {0} para usuario ID - {1}", Thread.CurrentThread.ManagedThreadId, tmpUser);
			new Thread(() => Imprimir(tmpUser)).Start();
		}
		
		private static void crearUsuario()
		{
			int i;
			Console.WriteLine();
			Console.WriteLine("Creando Usuario() Hilo ID - {0}", Thread.CurrentThread.ManagedThreadId);
			// Simular la creación de dos usuarios
			for(i = 0; i < 2; i++)
			{
				// ID de usuario
				int tmpUsuario = i;
				crearHilo(tmpUsuario);
			}
		}
			
		public static void Main(string[] args)
		{
			
			// TODO: Implement Functionality Here
			Console.WriteLine("Hilo principal ID: {0}", Thread.CurrentThread.ManagedThreadId);
			
			listaa = new List <string> ();
			listaa.Add("A");
			listaa.Add("B");
			listaa.Add("C");
			listaa.Add("D");
			listaa.Add("E");
			listaa.Add("F");
			listaa.Add("G");
			listaa.Add("H");
			listaa.Add("I");
			
			crearUsuario();
			
			Console.WriteLine("Hilo principal completo");
			
			Console.ReadKey(true);
		}
	}
}