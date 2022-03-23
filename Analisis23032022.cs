/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 22/03/2022
 * Time: 11:09 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
// Caja de Herramientas
using System;

// Espacio de nombres
namespace MonitoAmongUs
{
	// Clase Monoito del AmongUs
	// Nombre de la clase debe iniciar con una letra mayúscula
	// Utilizar notación camello y letras y números
	class MonoAmongUs
	{
		/* ATRIBUTOS */
		private int color;
		private string nombre;
		private bool impostor;

		/* HANDLERS */
		// Getters y setters
		// lectura / escritura
		public int Color 
		{
			get { return this.color; }
			set { this.color = value; }
		}
		public string Nombre
		{
			get { return this.nombre; }
		}
		public bool Impostor
		{
			get { return this.impostor; }
		}
		
		/* MÉTODOS */
		// Constructor
		public MonoAmongUs()
		{
			// Iniciamos los atributos a algún valor
			this.color = 0;
			this.nombre = " ";
			this.impostor = false;		
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{			
			// Instanciar un objeto
			// Clase objeto = new ConstructorClase();
			MonoAmongUs mono1 = new MonoAmongUs();
			MonoAmongUs mono2 = new MonoAmongUs();
			
			// Esto da error por el nivel de protección de los datos
			//Console.WriteLine("{0}", mono1.nombre);
			
			// Modificar el atributo de manera indirecta con un handler
			Console.WriteLine("{0}", mono1.Color);	// getter
			mono1.Color = 5;						// setter
			Console.WriteLine("{0}", mono1.Color);	// getter
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}