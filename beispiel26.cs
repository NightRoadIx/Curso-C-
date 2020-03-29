using System;
using System.Collections.Generic;

namespace programa
{	
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Clase de tipo colección
			 * Listas
			 * Las listas son colecciones de datos que son utilizadas para almacenar elementos u objetos
			 * en forma de lista; se localizan en el espacio de nombres System.Collections.Generic
			 * */ 
			// Crear una lista utilizando la clase List
			// Se observa que se coloca entre <> el tipo de datos que tendrá la lista
			List<int> nuevaLista = new List<int>();
			// Esto genera una lista vacía
			
			// Para ir añadiendo elementos a la lista se utiliza el método Add() de la lista
			nuevaLista.Add(1);
			nuevaLista.Add(58);
			nuevaLista.Add(49);
			nuevaLista.Add(13);
			nuevaLista.Add(1000);
			nuevaLista.Add(7);
						
			// Se puede conocer la cantidad de elementos utilizando el atributo de la lista Count
			Console.WriteLine("Elementos de la lista {0}:", nuevaLista.Count);
			// Se puede acceder a los elementos de la lista por medio de un foreach
			foreach(int a in nuevaLista)
				Console.Write(a.ToString() + " ");
			
			// Utilizar el método Remove() elimina uno de los elementos de la lista, hay varias formas:
			// Remove(T) elimina la primera ocurrencia del objeto T en la lista
			// RemoveAt(valor) elimina el número de elemento valor en la lista
			// RemoveRange(a, b) elimina el intervalo de elementos con índices en [a, b]
			// Clear() este método elimina todos los elementos de la lista
			nuevaLista.Remove(1000);
			Console.WriteLine("\nNúmero de elementos en la lista: {0}", nuevaLista.Count);
			
			// Ordenar una lista
			//Esto se puede realizar mediante el método Sort()
			nuevaLista.Sort();
			// Se puede conocer la cantidad de elementos utilizando el atributo de la lista Count
			Console.WriteLine("Lista ordenada: ");
			// Se puede acceder a los elementos de la lista por medio de un foreach
			foreach(int a in nuevaLista)
				Console.Write(a.ToString() + " ");
			
			// El método Contains() de la Lista, indica si el elemento que se coloca se encuentra en la Lista
			// regresa un booleano
			Console.WriteLine("");
			if( nuevaLista.Contains(1000) )
				Console.WriteLine("El elemento se encuentra en la lista");
			else
				Console.WriteLine("El elemento se encuentra en la lista");
			
			Console.ReadKey();
		}
	}
}