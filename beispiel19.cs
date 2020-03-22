using System;

namespace herenaciacion01
{
	class Persona
	{
		/* Atributos de la clase Persona*/
		private string Nombre;
		private int Edad;
		private string CURP;
		
		/* Métodos de la clase Persona */
		// Constructor de la clase sin argumentos
		public Persona()
		{
			this.Nombre = "";
			this.Edad = 0;
			this.CURP = "";
		}
		// Constructor de la clase con argumentos
		public Persona(string nombre, int edad, string curp)
		{
			this.Nombre = nombre;
			this.Edad = edad;
			this.CURP = curp;
		}
		
		/* Getters (En este caso solo pondré getters para reducir el tamaño del código) */
		public string getNombre()
		{
			return this.Nombre;
		}
		public int getEdad()
		{
			return this.Edad;
		}
		public string getCurp()
		{
			return this.CURP;
		}
		
		
		// Método para indicar que se cumplen años y se incrementa la edad
		void Cumpleannos()
		{
			this.Edad++;
		}
	}
	
	/* Clase Trabajador, hereda de Persona */
	class Trabajador : Persona
	{
		/* Atributos de la clase Trabajador */
		private int Sueldo;
		
		/* Métodos de la clase */
		/*
		 * Constructor de la clase Trabajador 
		 * */
		/*
		 * Constructor de la clase Trabajador
		 * En este caso, se usará como base el 
		 * constructor de la clase padre Persona
		 * usando la palabra clave "base"
		 * */
		public Trabajador(string nombre, int edad, string curp, int sueldo) : base(nombre, edad, curp)
		{
			this.Sueldo = sueldo;
		}
		
		public int getSueldo()
		{
			return this.Sueldo;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			Trabajador p = new Trabajador("Juan Nepomuceno", 22, "XXXX####nnnnn", 1000);
			
			Console.WriteLine("Nombre: " + p.getNombre());
			Console.WriteLine("Edad  : " + p.getEdad().ToString());
			Console.WriteLine("CURP  : " + p.getCurp());
			Console.WriteLine("Sueldo: " + p.getSueldo().ToString());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}