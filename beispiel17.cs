using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace listalangues
{
	class Program
	{
		public class NamePropertyComparer<T> : IComparer<T>
		{
			// Función requerida para mostrar los atributos de CultureInfo
			public int Compare(T x, T y)
			{
				if(x == null)
					if(y == null)
						return 0;
					else
						return -1;
				PropertyInfo pX = x.GetType().GetProperty("Name");
				PropertyInfo pY = y.GetType().GetProperty("Name");
				
				return String.Compare((string) pX.GetValue(x, null), (string) pY.GetValue(y, null));
			}
		}
		
		public static void Main(string[] args)
		{	
			Console.WriteLine("{0,-53}{1}", "CULTURA", "CULTURA ESPECÍFICA");
			
			// Obtener cada cultura neutra en el Framework .NET
			CultureInfo[] culturas = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
			// Ordenar el arreglo por nombre
			Array.Sort<CultureInfo>(culturas, new NamePropertyComparer<CultureInfo>());
			
			// Determinar la cultura específica asociada con cada cultura neutra
			foreach (var cultura in culturas)
			{
				// Mostrar el nombre de la cultura y su nombre en inglés estándar
				Console.Write("{0,-12} {1,-40}", cultura.Name, cultura.EnglishName);
				// Se ingresa lo siguiente dentro de un try-catch por si aparece una excepción
				try{
					// Símbolo específico
					Console.WriteLine("{0}", CultureInfo.CreateSpecificCulture(cultura.Name).Name);
				}
				catch (ArgumentException) {
					Console.WriteLine("(No hay cultura específica asociada)");
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}