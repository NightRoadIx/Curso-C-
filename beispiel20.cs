using System;

namespace herenaciacion02
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
		
		/* Getters y Setters */
		public string getNombre()
		{
			return this.Nombre;
		}
		public void setNombre(string nombre)
		{
			this.Nombre = nombre;
		}
		public int getEdad()
		{
			return this.Edad;
		}
		public void setEdad(int edad)
		{
			this.Edad = edad;
		}
		public string getCurp()
		{
			return this.CURP;
		}
		public void setCurp(string curp)
		{
			this.CURP = curp;
		}
		
		
		// Método para indicar que se cumplen años y se incrementa la edad de la clase Persona
		// cuando se utiliza la palabra "virtual" se está generando un método que puede ser modificado en la clase hija
		public virtual void Cumpleannos()
		{
			this.Edad++;
			Console.WriteLine("Incremento la edad de la Persona!");
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
		
		// Ahora se hará una sobrecarga de la función Cumpleannos, la cual se declaró en la clase
		// Persona como virtual, lo cual permite redefinir en la clase hija este método
		// usando la palabra override
		// Por tanto el método Cumpleannos heredado de Persona, se redefine y por lo tanto
		// termina siendo como si no se hubiera heredado
		public override void Cumpleannos()
		{
			int edad = this.getEdad();
			this.setEdad(edad++);
			Console.WriteLine("Incremento la edad del Trabajador!");
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			// Implementar un objeto Persona
			Persona p = new Persona("José María Morelos", 50, "NNNNnnnnxxxxx");
			// Implementar un objeto Trabajador
			Trabajador t = new Trabajador("Juan Nepomuceno", 22, "XXXX####nnnnn", 1000);
			
			// Ahora se mandan a llamar los métodos de Cumpleannos de cada clase
			t.Cumpleannos();
			p.Cumpleannos();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}