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

// Espacio de nombres (crear la caja de herramientas)
namespace MonitoAmongUs
{
	
	// Variables globales
	public enum coloritos
	{
		Negro = 0,
		Azul = 9,
		Verde = 10,
		Rojo = 12,
		Cian = 11,
		Magenta = 13,
		Amarillo = 14,
		Gris = 7,
		Blanco = 15
	}
	
	// Clase Monito del AmongUs
	// Nombre de la clase debe iniciar con una letra mayúscula
	// Utilizar notación camello y letras y números
	class MonoAmongUs
	{
		
		/* ATRIBUTOS */
		private int color;
		private string nombre;
		private bool impostor;
		// Constante que no cambiará
		private const double PI = 3.1416;

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
			set { this.nombre =  value; }
		}
		public bool Impostor
		{
			get { return this.impostor; }
			set { this.impostor =  value; }
		}
		
		/* MÉTODOS */
		// Constructor 1
		public MonoAmongUs()
		{
			// Iniciamos los atributos a algún valor
			this.color = 0;
			this.nombre = " ";
			this.impostor = false;			
		}
		
		// Constructor2
		public MonoAmongUs(int farbe, string name, bool samozvanets)
		{
			this.color = farbe;
			this.nombre = name;
			this.impostor = samozvanets;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{			
			// Instanciar un objeto
			// Clase objeto = new ConstructorClase();
			MonoAmongUs mono1 = new MonoAmongUs();
			MonoAmongUs mono2 = new MonoAmongUs(9, "Emmanuel", true);
			
			// Esto da error por el nivel de protección de los datos
			//Console.WriteLine("{0}", mono1.nombre);
			
			// Modificar el atributo de manera indirecta con un handler
			/*Console.WriteLine("{0}", mono1.Color);	// getter
			mono1.Color = 5;						// setter
			Console.WriteLine("{0}", mono1.Color);	// getter
			*/
			Console.WriteLine("-Nuestro jugador-");
			// Cambiamos el color de las letras
			Console.ForegroundColor = (ConsoleColor)mono2.Color;
			Console.WriteLine("{0}", mono2.Nombre);
			Console.WriteLine("{0}", (coloritos)mono2.Color);
			Console.WriteLine("{0}", mono2.Impostor);
			
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
	}
}