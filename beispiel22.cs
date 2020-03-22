using System;

namespace metodosmuchosdatos
{
	class Program
	{
		/* Es posible crear funciones con parámeros no definidos, esto es, que pueda recibir cualquier cantidad
		 * de parámetros, desde 0 hasta n
		 * lo único que se requiere es utilizar la palabra "params" y después especificar que tipo de dato es el 
		 * que se requiere recibir... en cao de querer englobar la mayor cantidad de tipos de datos, se usa el tipo "object"
		 * y se coloca entonces como un arreglo */
		static void F(int x, params object[] extras)
		{
			Console.WriteLine("Se obtiene el parámetro entero: " + x.ToString());
			for(int i = 0; i < extras.Length; i++)
				Console.WriteLine(extras[i]);
		}
		
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			// Llamar al método
			F(0); // No se mandan parámetros adicionales
			F(5, 1, 2, 3, 4, 5); // Se mandan 5 parámetros de tipo entero
			F(3, 4, "hola!", 3.1416); // Se mandar 3 parámetros de diferente tipo
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}