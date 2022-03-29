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
		negro = 0,
		azul = 9,
		verde = 10,
		rojo = 12,
		cian = 11,
		magenta = 13,
		amarillo = 14,
		gris = 7,
		blanco = 15
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
		
		// Mostrar el personaje
		public void mostrarDatos()
		{
			Console.WriteLine("-Nuestro jugador-");
			// Cambiamos el color de las letras
			Console.ForegroundColor = (ConsoleColor)this.color;
			Console.WriteLine("{0}", this.nombre);
			Console.WriteLine("{0}", (coloritos)this.color);
			Console.WriteLine("{0}", this.impostor);			
		}
		
		// Cuando el personaje realiza una acción
		public void realizarAcciones(string accion = "Ninguna")
		{
			Console.WriteLine("{0} está realizando la acción: {1}",
			                 this.nombre, accion);
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			/*
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
			
			MonoAmongUs mono2 = new MonoAmongUs();
			Console.Write("Nombre: ");
			// TODO: Función que limite el ingreso a caracteres alfanuméricos
			mono2.Nombre = Console.ReadLine();
			Console.Write("Color: ");
			mono2.Color = (int)Enum.Parse(typeof(coloritos), Console.ReadLine().ToLower());
			//color = Console.ReadLine().ToLower();
			Console.Write("Impostor (s/n): ");
			// TODO: Crear una función que sólo permita ingresar s/n
			// y regresar un char
			mono2.Impostor = Convert.ToChar(Console.ReadLine()) == 's' ? true : false;
			//impostor = Convert.ToChar(Console.ReadLine());
			
						
			// Cambiar a minusculas la cadena "color"
			// color = color.ToLower();
			//mono2.Color = (int)Enum.Parse(typeof(coloritos), color);
			//Console.WriteLine("Seleccionaste: {0}", color);
			//Console.WriteLine("Seleccionaste: {0}", mono2.Color);
			//mono2.Nombre = nombre;
			// Operador ternario
			// if(impostor == 's') mono2.Impostor = true;
			// else mono2.Impostor = false;
			//mono2.Impostor = impostor == 's' ? true : false;
			
			mono2.mostrarDatos();
			mono2.realizarAcciones("Tarea 1");
			
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
			
		}
	}
}