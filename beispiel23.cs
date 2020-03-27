using System;
using System.IO;

namespace taxomnia
{
	
	/* Clase super padre, Reino */
	class Reino
	{
		/* ATRIBUTOS */
		// Los atributos private solo se manejan dento de la clase
		private string[] Dominios = {"Archae","Bacteria","Eukarya"};
		private string[] Reinos = {"Protista","Fungi","Plantae","Animalia"};		
		// Los atributos protected solo se manejan dentro de la clase y sus clases hijas
		protected string dominio;
		protected string reino;
		
		/* MÉTODOS */
		// Getters y Setters de los atributos
		public void setDominio(string dom)
		{
			this.dominio = dom;
		}
		public string setDominio()
		{
			return this.dominio;
		}		
		public void setReino(string rey)
		{
			this.reino = rey;
		}
		public string getReino()
		{
			return this.reino;
		}
		// Métodos de verificación
		public bool verificarDominio(string dom)
		{
			// verificar si existe dicho dominio, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string domine in Dominios)
				// Verificar cuando se encuentre el dominio, regresar un verdadero
				if( domine.ToLower().Equals(dom.ToLower()) )
					return false;
			return true;
		}
		
		public bool verificarReino(string rey)
		{
			// verificar si existe dicho reino, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string rein in Reinos)
				// Verificar cuando se encuentre el reino, regresar un verdadero
				if( rein.ToLower().Equals(rey.ToLower()) )
					return false;
			return true;
		}
	}
	
	/* clase hija de Reino Animalia */
	class Animalia : Reino
	{
		/* ATRIBUTOS */
		// Los atributos private solo se manejan dento de la clase
		private string[] Clase = {"Aneelida", "Arthropoda", "Brachiopoda", "Bryozoa", "Chordata", "Echinodermata", "Hemicohordata", "Loricefera", "Mammalia", "Mollusca", "Nematoda", "Phoronida", "Rhombozoa", "Tardigrada"};	
		// Los atributos protected solo se manejan dentro de la clase y sus clases hijas
		protected string claseAnimalia;

		/* MÉTODOS */
		public void setClaseAnimalia(string claseAnimal)
		{
			this.claseAnimalia = claseAnimal;
		}
		public string getClaseAnimalia()
		{
			return this.claseAnimalia;
		}
		public bool verificarClaseAnimalia(string clasAnim)
		{
			// verificar si existe dicho reino, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string clas in Clase)
				// Verificar cuando se encuentre el reino, regresar un verdadero
				if( clas.ToLower().Equals(clasAnim.ToLower()) )
					return false;
			return true;
		}
	}
	
	/* Clase Mammalia hija del Animalia, hija de Reino*/
	class Mammalia : Animalia
	{
		/* ATRIBUTOS */
		// Los atributos private solo se manejan dento de la clase
		private string[] Orden = {"Artilodacta","Carnivora","Chiroptera","Dinocerata","Litopterna","Mulituberculata","Primates","Rodentia","Scadentia"};	
		// Los atributos protected solo se manejan dentro de la clase y sus clases hijas
		protected string orden;
		
		/* MÉTODOS */
		public void setOrdenMammalia(string ordenAnimal)
		{
			this.orden = ordenAnimal;
		}
		public string getOrdenMammalia()
		{
			return this.orden;
		}
		public bool verificarOrdenMammalia(string ordenMamm)
		{
			// verificar si existe dicho reino, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string ord in Orden)
				// Verificar cuando se encuentre el reino, regresar un verdadero
				if( ord.ToLower().Equals(ordenMamm.ToLower()) )
					return false;
			return true;
		}
	}

	/* Clase Carnivora hija de Mammalia, hija del Animalia, hija de Reino*/
	class Carnivora : Mammalia
	{
		/* ATRIBUTOS */
		// Los atributos private solo se manejan dento de la clase
		private string[] Familia = {"Canidae", "Felidae", "Herpestidae","Hyanidae","Mustelidae","Ursidae"};	
		// Los atributos protected solo se manejan dentro de la clase y sus clases hijas
		protected string familia;
		
		/* MÉTODOS */
		public void setFamiliaCarnivora(string familcarniv)
		{
			this.familia = familcarniv;
		}
		public string getFamiliaCarnivora()
		{
			return this.familia;
		}
		public bool verificarFamiliaCarnivora(string familcarniv)
		{
			// verificar si existe dicho reino, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string fam in Familia)
				// Verificar cuando se encuentre el reino, regresar un verdadero
				if( fam.ToLower().Equals(familcarniv.ToLower()) )
					return false;
			return true;
		}
	}
	/* Clase Felidae, hija de Carnivora hija de Mammalia, hija del Animalia, hija de Reino */
	class Felidae : Carnivora
	{
		/* ATRIBUTOS */
		// Los atributos private solo se manejan dento de la clase
		private string[] Genero = {"Acinonyx", "Caracal", "Felis", "Leopardus", "Lynx", "Puma", "Panthera"};
		// Los atributos protected solo se manejan dentro de la clase y sus clases hijas
		protected string genero;
		
		/* MÉTODOS */
		public void setGeneroFelidae(string generofelid)
		{
			this.genero = generofelid;
		}
		public string getGeneroFelidae()
		{
			return this.genero;
		}
		public bool verificarGeneroFelidae(string generofelid)
		{
			// verificar si existe dicho reino, recorriendo sobre todos los Reinos que se tienen almacenados 
			foreach(string gen in Genero)
				// Verificar cuando se encuentre el reino, regresar un verdadero
				if( gen.ToLower().Equals(generofelid.ToLower()) )
					return false;
			return true;
		}
	}
	
	/* Clase gato, hija de Felidae, hija de Carnivora hija de Mammalia, hija del Animalia, hija de Reino */
	class Gato : Felidae
	{
		/* Atributos */
		protected string especie;
		protected string raza;
		
		// Constructor
		public Gato()
		{
			// Se inician todas los atributos a vacío
			this.dominio = "";
			this.reino = "";
			this.claseAnimalia = "";
			this.orden = "";
			this.familia = "";
			this.genero = "";
			this.especie = "";
			this.raza = "";
		}
		
		public void setEspecie(string espec)
		{
			this.especie = espec;
		}
		public void setRaza(string raz)
		{
			this.raza = raz;
		}
		public void imprimir()
		{
			Console.WriteLine("Dominio: " + this.dominio);
			Console.WriteLine("Reino  : " + this.reino);
			Console.WriteLine("Clase  : " + this.claseAnimalia);
			Console.WriteLine("Orden  : " + this.orden);
			Console.WriteLine("Familia: " + this.familia);
			Console.WriteLine("Genero : " + this.genero);
			Console.WriteLine("Especie: " + this.especie);
			Console.WriteLine("Raza   : " + this.raza);
			
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			// Crear un objeto de la clase Gato
			Gato nuevoGato = new Gato();
			string tmp;
			/* Verificar que el árbol filogenético del gato sea el correcto */
			/*
			 * Probar con:
			 * Dominio: Eurkarya
			 * Reino  : Animalia
			 * Clase  : Mammalia
			 * Orden  : Carnivora
			 * Familia: Felidae
			 * Genero : Felis
			 * Especie: Catus
			 * Raza   : Hay varias... Angora, Abisinio, Burmés, Bengala, Mnax, Himalayo, Pixie, Ocicat, Oriental, Siamés, Siberiano, etc...
			 * */
			
			
			// Ingresar el Dominio (observar como se utiliza el método heredado)
			do
			{
				Console.Write("Ingresar Dominio: ");
				tmp = Console.ReadLine();
			}
			while(nuevoGato.verificarDominio( tmp ));
			// Colocar el Dominio
			nuevoGato.setDominio(tmp);
			
			// Verificar el Reino
			do
			{
				Console.Write("Ingresar Reino: ");
				tmp = Console.ReadLine();
			}
			while( nuevoGato.verificarReino( tmp ) );
			// Una vez pasado, se ingresa el reino
			nuevoGato.setReino(tmp);
			
			// Verificar la Clase
			do
			{
				Console.Write("Ingresar Clase: ");
				tmp = Console.ReadLine();
			}
			while( nuevoGato.verificarClaseAnimalia( tmp ) );
			// Una vez pasado, se ingresa la clase
			nuevoGato.setClaseAnimalia(tmp);
			
			// Verificar el orden
			do
			{
				Console.Write("Ingresar Orden: ");
				tmp = Console.ReadLine();
			}
			while( nuevoGato.verificarOrdenMammalia(tmp) );
			// Una vez pasado, se ingresa la clase
			nuevoGato.setOrdenMammalia(tmp);
			
			// Verificar la familia
			do
			{
				Console.Write("Ingresar Familia: ");
				tmp = Console.ReadLine();
			}
			while( nuevoGato.verificarFamiliaCarnivora(tmp) );
			// Una vez pasado, se ingresa la clase
			nuevoGato.setFamiliaCarnivora(tmp);
			
			// Verificar el genero
			do
			{
				Console.Write("Ingresar Genero: ");
				tmp = Console.ReadLine();
			}
			while( nuevoGato.verificarGeneroFelidae(tmp) );
			// Una vez pasado, se ingresa la clase
			nuevoGato.setGeneroFelidae(tmp);

			// Ingresar Especie y Raza
			Console.Write("Ingresar Especie: ");
			tmp = Console.ReadLine();
			nuevoGato.setEspecie(tmp);
			Console.Write("Ingresa Raza: ");
			tmp = Console.ReadLine();
			nuevoGato.setRaza(tmp);
			
			/* Una vez ingresadp todo de forma correcta, imprimir */
			nuevoGato.imprimir();
			
			
			Console.ReadKey();
		}
	}
}