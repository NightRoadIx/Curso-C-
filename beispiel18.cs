using System;

namespace poderes
{
	// Superclase animales (tiene que ser pública)
	public class Animales
	{
		// Atributos
		// se deben de marcar como protected, esto permite que estos atributos
		// solo puedan ser utilizados en la clase contenedora y las clases hijas 
		// que heredan de la clase padre o superclase
		protected string orden;
		protected string familia;
		protected string habitat;
		protected double tamanno;
		protected int longevidad;
		protected string alimentacion;

		// Constructor
		public Animales()
		{
			this.orden = "";
			this.familia = "";
			this.habitat = "";
			this.tamanno = 0.0;
			this.longevidad = 0;
			this.alimentacion = "";
		}
		
		// Destructor
		// esta es la otra función especial que se manda a llamar cuando
		// el objeto se termina
		// Muchas veces en este punto se realiza la eliminación de las variables
		// y datos que fueron iniciados en el objeto
		~Animales()
		{
			Console.WriteLine("El objeto de la clase Animales se termino");
		}
		
		/*
		  * Las dos siguientes funciones sustituyen de alguna manera
		  * los getters y setters de cada uno de los atributos
		  * */
		public void acept()
		{
			Console.Write("Teclea el orden       : ");
			this.orden = Console.ReadLine();
			Console.Write("Teclea la familia     : ");
			this.familia = Console.ReadLine();
			Console.Write("Teclea el habitat     : ");
			this.habitat = Console.ReadLine();
			Console.Write("Teclea el tamaño      : ");
			this.tamanno = Convert.ToDouble(Console.ReadLine());
			Console.Write("Teclea la longevidad  : ");
			this.longevidad = Convert.ToInt32(Console.ReadLine());
			Console.Write("Teclea la alimentación: ");
			this.alimentacion = Console.ReadLine();
		}
		
		public void imprimir()
		{
			Console.WriteLine("Orden       : " + this.orden);
			Console.WriteLine("Familia     : " + this.familia);
			Console.WriteLine("Hábitat     : " + this.habitat);
			Console.WriteLine("Tamaño      : " + this.tamanno.ToString());
			Console.WriteLine("Longevidad  : " + this.longevidad.ToString());
			Console.WriteLine("Alimentación: " + this.alimentacion);
		}
	}
	
	/* Clase Mamiferos que hereda de la clase padre Animales */
	public class Mamiferos : Animales
	{
		// Atributos de la clase hija
		protected int t_gestacion;
		protected string tipoParto;
		
		// Métodos de la clase hija
		// Constructor Mamiferos
		public Mamiferos()
		{
			this.t_gestacion = 0;
			this.tipoParto = "";
		}
		
		// Destructor
		~Mamiferos()
		{
			Console.WriteLine("El objeto de la clase Mamiferos se termino");
		}
	}
	
	// Clase Gato, que hereda de Mamiferos y por ende de Animales
	public class Gato : Mamiferos
	{
		// Atributos
		private string raza;
		
		// Métodos
		// Constructor
		public Gato()
		{
			this.raza = ""; // Bonita como debe de ser			
		}
		
		// Destructor
		~Gato()
		{
			Console.WriteLine("El objeto de la clase Gato se termino");
		}
		
		// Versión del set para colocar información del Gato
		public void aceptar()
		{
			Console.WriteLine("*** GATO ***");
			// Mandar a llamar el método heredado de la clase Mamiferos heredado de la clase Animales
			this.acept();
			Console.Write("Teclea el tiempo de gestación: ");
			this.t_gestacion = Convert.ToInt32(Console.ReadLine());
			Console.Write("Teclea el tipo de parto      : ");
			this.tipoParto = Console.ReadLine();
			Console.Write("Teclea la raza               : ");
			this.raza = Console.ReadLine();
		}
		
		// Versión del get para obtener información del Gato
		public void imprime()
		{
			Console.WriteLine("*** GATO ***");
			// Mandar a llamar el método heredado de la clase Mamiferos heredado de la clase Animales
			this.imprimir();
			Console.WriteLine("Tiempo de gestación: " + this.t_gestacion.ToString());
			Console.WriteLine("Tipo de parto      : " + this.tipoParto);
			Console.WriteLine("Raza               : " + this.raza);
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			// Se instancia un objeto
			Gato nuevoGato = new Gato();
			
			// Se manda a pedir la información
			nuevoGato.aceptar();
			
			// Se imprime una vez solicitada
			nuevoGato.imprime();
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}