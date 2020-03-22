using System;

/*
 * Espacio de nombres
 * De la misma manera que los archivos se organizan en directorios, los tipos de datos en C#
 * se organizan en espacio de nombres "namespace"
 * Esto permite tener más organizados los tipos de datos, facilitando su localización
 * De esta forma, casi todos las clases usadas en las aplicaciones pertenecen al espacio de nombres
 * "System" y de ahí en fuera existen System.IO, System.Globalization, etc.
 * Lo cual se manda a llamar con la palabra clave "using", lo que evita el tener que usar el nombre
 * laaaaaaaaaaaaaaaaargo de algún método o atributo de una clase del algún espacio de nombres
 * Por ejemplo System.IO permite acceder a los métodos para escritura de archivos
 * */
namespace espacioNombres
{
	// Ahora es posible tambien anidar espacios de nombres en otros
	// Recuerden que C# es como jugra con Matroshkas... cada vez van saliendo mas y más
	namespace espacioInterior
	{
		public class Interna
		{
			public void metodoInterno()
			{
				Console.WriteLine("Como viajar al centro de la Tierra");
			}
		}
	}
	// De esta forma, entonces la clase Program en realidad es espacioNombres.Program
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			// OBSERVAR QUE SI NO SE HACE USO DEL ESPACIO DE NOMBRE SYSTEM.IO, SE TIENE QUE DAR
			// TODA LA "RUTA" PARA ACCEDER A LOS MÉTODOS
			// System.IO.File.WriteAllText();
			
			// Se genera un objeto
			espacioNombres.espacioInterior.Interna p = new espacioNombres.espacioInterior.Interna();
			
			// Se usa el método
			p.metodoInterno();
			
			// De esta forma se puede ir observando como se puede ir creando espacios de nombres para crear "librerías"
			// Que pueden ser utilizadas por otros programas, las cuales contengan clases que pueden ser heredadas o modificadas
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}