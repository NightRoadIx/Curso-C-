using System;

namespace estaticasizacion
{
	// Una clase cualquiera
	class miClase
	{
		/* ATRIBUTOS */
		// Sin atributos
		
		/* METODOS */
		public int MetodoInstancia()
		{
			return 1;
		}
		
		/* Static significa que está asociado con un tipo en lugar de cualquier instancia de tipo
		 * Entonces hay un conjunto de variables estáticas para un tip o, las cuales no requerirán
		 * que se instancia un objeto para poder acceder a ellas
		 * */
		public static int MetodoStatic()
		{
			return 2;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			// Se instancia un objeto de la clase generada
			miClase instancia = new miClase();
			Console.WriteLine(instancia.MetodoInstancia()); //Esto se ejecuta sin problemas
			Console.WriteLine(miClase.MetodoStatic()); // Esto también
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}