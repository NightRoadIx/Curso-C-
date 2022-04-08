/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 01/04/2022
 * Time: 11:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Figuras
{
	/* Clases de las figuras */
	/* Clase Figura */
	class Figura
	{
		/* ATRIBUTOS */
		protected double perimetro;
		protected double area;
		protected string nombreFigura;
		
		/* MÉTODOS */
		// Constructor
		public Figura(string figName)
		{
			this.perimetro = 0.0;
			this.area = 0.0;
			// Pasar el nombre de la figura en este punto 
			this.nombreFigura = figName;
		}
		public virtual void calcularPerimetro()
		{
			this.perimetro = 0.0;
		}
		
		public virtual void calcularArea()
		{
			this.area = 0.0;
		}
		
		public void imprimirFigura()
		{
			Console.WriteLine("Figura   : {0}", this.nombreFigura);
			Console.WriteLine("Perimetro: {0} u", this.perimetro);
			Console.WriteLine("Área     : {0} u^2", this.area);
		}
	}
	
	/* Clase Cuadrado */
	class Cuadrado : Figura
	{
		/* ATRIBUTOS */
		private double lado;
		
		/* HANDLERS */
		public double Lado 
		{
			get { return this.lado; }
			set { this.lado = value; }
		}
		
		/* MÉTODOS */
		// Constructor
		public Cuadrado(double side = 0.0) : base("Cuadrado")
		{
			// Asignar el valor del lado
			this.lado = side;
			// Se calculan los otros atributos
			this.calcularPerimetro();
			this.calcularArea();
		}
		
		// Calcular el perimetro de un cuadrado
		public override void calcularPerimetro()
		{
			this.perimetro = lado * 4.0f;
		}
		
		// Calcular el área de un cuadrado
		public override void calcularArea()
		{
			this.area = lado * lado;
		}
		
		// Función para mostrar los datos de la figura
		public void mostrarDatos()
		{
			this.imprimirFigura();
			Console.WriteLine("Lado     : {0} u", this.lado);
		}		
	}
	
	/* Clase Rectángulo */
	class Rectangulo : Figura
	{
		/* ATRIBUTOS */
		private double basse;
		private double altura;
		
		/* HANDLERS */
		public double Basse
		{
			get { return this.basse; }
			set { this.basse = value; }
		}
		public double Altura
		{
			get { return this.altura; }
			set { this.altura = value; }
		}
		
		/* MÉTODOS */
		// Constructor
		public Rectangulo(double baza = 0.0, double inaltimea = 0.0) : base("Rectángulo")
		{
			// Asignar el valor de la base y la altura
			this.basse = baza;
			this.altura = inaltimea;
			// Se calculan los otros atributos
			this.calcularPerimetro();
			this.calcularArea();
		}
		
		// Destructor de clase (no es totalmente necesario)
		~Rectangulo()
		{
			Console.WriteLine("El objeto Rectangulo se termino");
			Console.ReadKey();
		}
		
		// Calcular el perimetro de un rectángulo
		public override void calcularPerimetro()
		{
			this.perimetro = 2 * basse + 2 * altura;
		}
		
		// Calcular el área de un rectángulo
		public override void calcularArea()
		{
			this.area = basse * altura;
		}
		
		// Función para mostrar los datos de la figura
		public void mostrarDatos()
		{
			this.imprimirFigura();
			Console.WriteLine("Base     : {0:N2} u", this.basse);
			Console.WriteLine("Altura   : {0:N2} u", this.altura);
		}		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			// Instanciar un objeto (asignar memoria)
			// Clase objeto = new ConstructorClase();
			Cuadrado cuadro = new Cuadrado(2.0);
			cuadro.mostrarDatos();
			
			//Rectangulo rectan = new Rectangulo(3.32, 2.42);
			//rectan.mostrarDatos();
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}