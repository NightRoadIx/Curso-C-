using System;

namespace objetizacion
{
	/* Clase Figura */
	class Figura
	{
		/* ATRIBUTOS */
		// En este caso los atributos son protegidos, esto es que
		// solo pueden ser vistos desde las clases hijas
		protected double perimetro;
		protected double area;
		
		/* MÉTODOS */
		// Constructor
		// Inicia los valores a 0.0
		public Figura()
		{
			this.perimetro = 0.0;
			this.area = 0.0;
		}
		// Acceso a los atributos
		// en este caso son solo de lectura (getter)
		public double Perimetro
		{
			get { return perimetro; }
		}
		public double Area
		{
			get { return area; }
		}
		// Esta función también es protegida, sin embargo, se podría
		// tratar también como pública
		// Regresa una cadena de texto con los valores del perimetro y del área
		protected string imprimirFigura()
		{
			return "\nPerimetro : " + this.perimetro.ToString() + "\nArea      : " + this.area.ToString();
		}
	}
	
	class Cuadrado : Figura
	{
		/* ATRIBUTOS */
		private double lado;
		
		/* MÉTODOS */
		// Constructor por defecto
		public Cuadrado() : base()
		{
			this.lado = 0.0;
		}
		// Constructor con valores iniciales
		public Cuadrado(double lonLado)
		{
			this.lado = lonLado;
		}
		// Getters y setters
		public double Lado
		{
			get { return lado; }
			set { lado = value; }
		}
		
		public void calcularPerimetro()
		{
			this.perimetro = this.lado * 4.0;
		}
		
		// Calcular el area
		public void calcularArea()
		{
			this.area = this.lado * this.lado;
		}
		
		// Enviar una cadena de texto
		public string imprimirCuadrado()
		{
			return "\nLado   : " + this.lado.ToString() + base.imprimirFigura();
		}
		
	}
	
	/* Clase Rectangulo, hereda de Figura */
	class Rectangulo : Figura
	{
		/* ATRIBUTOS */
		// Los atributos de la clase padre (Figura) son heredados
		private double base1;
		private double altura;
				
		/* MÉTODOS */
		// Constructores
		// Por defecto, sin iniciar ningun valor, se incluye el constructor de la case padre
		public Rectangulo() : base()
		{
			this.base1 = 0.0;
			this.altura = 0.0;
		}
		// Constructor con ciertas variables, esto muestra también el polimorfismo
		public Rectangulo(double lonBase, double lonAltura)
		{
			this.base1 = lonBase;
			this.altura = lonAltura;
		}
		
		// Getters, setters
		// Lecto-escritura
		public double Base1
		{
			get { return base1; }
			set { base1 = value; }
		}
		public double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		// Calcular el perímetro
		public void calcularPerimetro()
		{
			this.perimetro = 2.0 * (this.base1 + this.altura);
		}
		
		// Calcular el area
		public void calcularArea()
		{
			this.area = this.base1 * this.altura;
		}
		
		// Enviar una cadena de texto
		public string imprimirRectangulo()
		{
			return "\nBase   : " + this.base1.ToString() + "\nAltura : " + this.altura.ToString() + base.imprimirFigura();
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			// INSTANCIAR UN OBJETO A PARTIR DE UNA CLASE
			// Se utiliza el constructor por defecto
			Rectangulo miRectangulo = new Rectangulo();
			
			// Aquí se usan los setters para modificar los atributos
			miRectangulo.Altura = 10.0;
			miRectangulo.Base1 = 5.0;
			
			// Se mandan a llamar las funciones que calculan los valores
			miRectangulo.calcularPerimetro();
			miRectangulo.calcularArea();
			
			// Imprimir los valores
			Console.WriteLine( miRectangulo.imprimirRectangulo() );
			
			/* Crear otro objeto */
			Rectangulo miRectangulo2 = new Rectangulo();			
			miRectangulo2.Altura = 1.0;
			miRectangulo2.Base1 = 3.1416;			
			miRectangulo2.calcularPerimetro();
			miRectangulo2.calcularArea();			
			Console.WriteLine( miRectangulo2.imprimirRectangulo() );
			
			/* Ahora generar otro objeto, pero con el constructor con datos */
			Rectangulo miRectangulo3 = new Rectangulo(4, 3);			
			miRectangulo3.calcularPerimetro();
			miRectangulo3.calcularArea();			
			Console.WriteLine(miRectangulo3.imprimirRectangulo());
			
			// Instanciar un cuadrado
			Cuadrado miCuadro = new Cuadrado(3);
			miCuadro.calcularPerimetro();
			miCuadro.calcularArea();
			Console.WriteLine( miCuadro.imprimirCuadrado() );
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}