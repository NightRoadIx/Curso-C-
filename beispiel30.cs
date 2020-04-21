using System;
using System.Collections.Generic;

namespace tcomplexity
{
	class Program
	{
		/* Función con complejidad O(1) - Verificar si el primer elemento de una lista es nulo o vacío */
		public static bool esPrimerElementoNuloOVacio(List<string> elements)
		{
			// Si la lista que se envía está vacía mandar un error
			if(elements == null)
				throw new ArgumentNullException("elementos");
			
			// En caso de que la lista no este vacía
			if(elements.Count > 0)
			{
				// cuando el primer elemento este nulo o vacío
				if(string.IsNullOrEmpty(elements[0]))
					return true;
			}
			// Si no se cumple, se envía falso
			return false;
			// En este caso no importa si se envía una lista de 1 o 1234567 elementos
			// El número de operaciones siempre es el mismo
		}
		
		/* Función con complejidad O(n) - Hallar un elemento en una lista, recorriendo elemento a elemento */
		public static bool contieneValor(List<string> elements, string elementoAHallar)
		{
			if(elements == null)
				throw new ArgumentNullException("elementos");
			
			if(elements.Count > 0)
			{
				for(int count = 0; count < elements.Count; count++)
					// Aquí hay que recordar que es posible hallar el elemento en la 1a iteración
					// o en las primeras, sin emabrgo siempre se considera el peor de los casos
					// en el análisis de la complejidad
					if(elements[count].Equals(elementoAHallar))
						return true;
			}
			return false;
		}
		
		/* Función con complejidad O(n^2) - Veriricar si existen duplicados en una lista */
		public static bool contieneDuplicados(List<string> elements)
		{
			if(elements == null)
				throw new ArgumentNullException("elementos");
			
			if(elements.Count > 0)
			{
				// Recorrer toda la lista
				for(int i = 0; i < elements.Count; i++)
				{
					// Esto también recorre toda la lista
					for(int j = 0; j < elements.Count; j++)
					{
						// Cuando los índices sean iguales no hacer nada y efectuar el siguiente ciclo
						if(i == j)
							continue;
						// Cuando se halle un valor igual
						if(elements[i].Equals(elements[j]))
							return true;
					}
				}
			}
			return false;
			// De la misma forma se está considerando el peor de los escenarios (además de que se puede hacer más eficiene el programa)			
		}
		
		
		/* Función con complejidad O(log n) - Búsqueda binaria */
		// IMPORTANTE: Los elementos deben de estar ordenados de menor a mayor
		public static int BusquedaBinaria(List<int> elements, int valorABuscar)
		{
			if(elements == null)
				throw new ArgumentNullException("elementos");
			
			// si el primer elemento es mayor al valor a buscar, se descarta
			if(elements[0] > valorABuscar)
				return -1;
			// si el valor a buscar es mayor que el último elemento también se decarta
			if(valorABuscar > elements[elements.Count - 1])
				return -1;
			
			int l = 0, h = elements.Count;
			
			while(l < h)
			{
				// Aquí se va partiendo a la mitad la lista
				int mid = (h + l)/2;
				if(elements[mid] < valorABuscar)
					l = mid;
				else if(elements[mid] > valorABuscar)
					h = mid;
				else
					return mid;
			}
			return -1;
		}
		
		public static void Main(string[] args)
		{
			
			// TODO: Implement Functionality Here
			/* AQUI ES DONDE SE MANDAN A LLAMAR ESTAS FUNCIONES, LO DEJO COMO EJERCICIO */
			
			Console.ReadKey(true);
		}
	}
}