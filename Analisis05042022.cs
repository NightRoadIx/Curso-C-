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
	/* Clase Cuadrado */
	class Cuadrado
	{
		/* ATRIBUTOS */
		private double lado;
		private double perimetro;
		private double area;
		
		/* HANDLERS */
		public double Lado 
		{
			get { return this.lado; }
			set { this.lado = value; }
		}
		public double Perimetro
		{
			get { return this.perimetro; }
		}
		public double Area
		{
			get { return this.area; }
		}
		
		/* MÉTODOS */
		// Constructor
		public Cuadrado(double side = 0.0)
		{
			// Asignar el valor del lado
			this.lado = side;
			// Se calculan los otros atributos
			this.calcularPerimetro();
			this.calcularArea();
		}
		
		// Calcular el perimetro de un cuadrado
		public void calcularPerimetro()
		{
			this.perimetro = lado * 4.0f;
		}
		
		// Calcular el área de un cuadrado
		public void calcularArea()
		{
			this.area = lado * lado;
		}
		
		// Función para mostrar los datos de la figura
		public void mostrarDatos()
		{
			Console.WriteLine("Figura   : Cuadrado");
			Console.WriteLine("Lado     : {0} u", this.lado);
			Console.WriteLine("Perimetro: {0} u", this.perimetro);
			Console.WriteLine("Área     : {0} u^2", this.area);
		}		
	}
	
	/* Clase Rectángulo */
	class Rectangulo
	{
		/* ATRIBUTOS */
		private double basse;
		private double altura;
		private double perimetro;
		private double area;
		
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
		public double Perimetro
		{
			get { return this.perimetro; }
		}
		public double Area
		{
			get { return this.area; }
		}
		
		/* MÉTODOS */
		// Constructor
		public Rectangulo(double baza = 0.0, double inaltimea = 0.0)
		{
			// Asignar el valor de la base y la altura
			this.basse = baza;
			this.altura = inaltimea;
			// Se calculan los otros atributos
			this.calcularPerimetro();
			this.calcularArea();
		}
		
		// Destructor de clase
		~Rectangulo()
		{
			Console.WriteLine("El objeto Rectangulo se termino");
			Console.ReadKey();
		}
		
		// Calcular el perimetro de un rectángulo
		public void calcularPerimetro()
		{
			this.perimetro = 2 * basse + 2 * altura;
		}
		
		// Calcular el área de un rectángulo
		public void calcularArea()
		{
			this.area = basse * altura;
		}
		
		// Función para mostrar los datos de la figura
		public void mostrarDatos()
		{
			Console.WriteLine("Figura   : Rectángulo");
			Console.WriteLine("Base     : {0:N2} u", this.basse);
			Console.WriteLine("Altura   : {0:N2} u", this.altura);
			Console.WriteLine("Perimetro: {0:N2} u", this.perimetro);
			Console.WriteLine("Área     : {0:N2} u^2", this.area);
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
			
			Rectangulo rectan = new Rectangulo(3.32, 2.42);
			rectan.mostrarDatos();
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}