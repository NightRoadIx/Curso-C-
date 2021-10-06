/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 27/09/2021
 * Time: 06:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace complejos
{		
	// Clase de numeros complejos
	// z = r + i
	public class NumComplejos
	{
		/* ATRIBUTOS */
		private double real;
		private double imag;
		
		/* MÉTODOS */		
		// Constructor por defecto
		public NumComplejos()
		{
			this.real = 0;
			this.imag = 0;
		}
		
		// Constructor con valores
		public NumComplejos(double re, double im)
		{
			this.real = re;
			this.imag = im;
		}
		
		// Getters y Setters
		// Getters
		public double getReal()
		{
			return this.real;
		}
		public double getImag()
		{
			return this.imag;
		}
		// Setters
		public void setReal(double re)
		{
			this.real = re;
		}
		public void setImag(double im)
		{
			this.imag = im;
		}
		
		// Mostrar el número complejo
		public void mostrarComplejos()
		{
			Console.WriteLine("{0} + {1}i",this.real, this.imag);
		}
		
		// Operaciones
		// Suma (a, b) + (c, d) = (a+c, b+d)
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
		
		// TODO: Generar la división
	}
	
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Programacización orientada a objetivización";
			
			// Instanciar un objeto complejo1 del tipo NumComplejos
			NumComplejos complejo1 = new NumComplejos(1, 2); // 1 + 2i
			NumComplejos complejo2 = new NumComplejos(3, 4); // 3 + 4i			
			NumComplejos complejo3 = new NumComplejos(); // 0 + 0i
			
			complejo1.mostrarComplejos();
			complejo2.mostrarComplejos();
			complejo3.mostrarComplejos();			
			
			complejo1.setReal(6.0);
			complejo1.mostrarComplejos();
			
			Console.WriteLine("Parte real complejo1: {0}", complejo1.getReal());
			
			complejo3 = complejo1.sumarComplejo(complejo2);
			Console.Write("Suma: "); complejo3.mostrarComplejos();
			
			// Instanciar el objeto
			NumComplejos complejo4 = new NumComplejos();
			Console.Write("Escriba un número complejo: ");
			// TODO: Leer el complejo en una sola línea????
			// Lectura de una cadena del tipo A+-Bi
			Console.ReadLine();
			
			Console.Write("Presione una tecla para continuar si fuése usted tan amable . . . ");
			Console.ReadKey(true);
		}
	}
}
