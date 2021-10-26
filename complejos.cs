/*
 * Created by SharpDevelop.
 * User: s_bio
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace objetosMaximo
{	
	// TODO: Clase para restringir el ingreso de datos
	// Clase 
	//public class 
	
	// TODO: Documentar bien toda la clase NumComplejos
	
	/// <summary>
	/// Aquí van los números complejos de la forma:
	/// complejo = real +/- imaginario
	/// <remarks>Aquí que hace?</remarks> 
	/// </summary>
	public class NumComplejos
	{
		/* ATRIBUTOS */
		private double real;
		private double imag;
		
		/* MÉTODOS */		
		// Constructor por defecto, inicia todo a 0
		public NumComplejos()
		{
			this.real = 0;
			this.imag = 0;
		}
		
		// Constructor con valores enviados como parámetros
		public NumComplejos(double re, double im)
		{
			this.real = re;
			this.imag = im;
		}
		
		// Getters y Setters
		public double Real
		{
			get; set;
		}
		public double Imag
		{
			get; set;
		}
		
		// Mostrar el número complejo, aquí se va a sobrecargar el método ToString
		public override string ToString()
		{
			return string.Format("{0} + {1}i\n", this.real, this.imag);
		}
		
		/* Operaciones */
		/// <summary>
		/// Suma de números complejos: 
		///  (a, b) + (c, d) = (a+c, b+d)
		/// </summary>
		/// <param name="c"> objeto NumComplejos a sumar</param>
		/// <returns> objeto NumComplejos, con el valor de la suma</returns>
		public NumComplejos sumarComplejo(NumComplejos c)
		{
			NumComplejos aux = new NumComplejos();
			aux.real = this.real + c.real;
			aux.imag = this.imag + c.imag;
			
			return aux;
		}
		// Resta (a, b) - (c, d) = (a-c, b-d)
		public NumComplejos restarComplejo(NumComplejos c)
		{
			NumComplejos aux = new NumComplejos();
			aux.real = this.real - c.real;
			aux.imag = this.imag - c.imag;
			
			return aux;
		}
		// Multiplica (a, b) * (c, d) = (ac - bd, ad + bc)
		public NumComplejos multiplicarComplejo(NumComplejos c)
		{
			NumComplejos aux = new NumComplejos();
			aux.real = this.real * c.real - this.imag * c.imag;
			aux.imag = this.real * c.imag - this.imag * c.real;
						
			return aux;
		}
		
		// Divide (a, b) / (c, d) = ((a*c + b*d) / (c^2 + d^2) , (b*c – a*d) / (c^2 + d^2))
		public NumComplejos dividirComplejo(NumComplejos c)
		{
			NumComplejos aux = new NumComplejos();
			aux.real = (this.real * c.real + this.imag * c.imag) / (c.real * c.real + c.imag * c.imag);
			aux.imag = (this.imag * c.real - this.real * c.imag) / (c.real * c.real + c.imag * c.imag);
						
			return aux;
		}
		
		// TODO: Incuir, potencia y raíz n-ésima de los números complejos
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			// Instanciar un objeto de número complejo con el valor 2+5i
			NumComplejos complejo1 = new NumComplejos(2, 5);
			
			// Mostrar el número complejo usando el método sobrecargado ToString()
			Console.Write( complejo1.ToString() );
			
			Console.Write("Presione cualquier tecla para continuar . . . ");
			Console.ReadKey(true);
			
		}
	}
}
