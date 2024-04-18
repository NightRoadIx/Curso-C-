// Esto sustituye al #include <> en C
// Permite usar atributos y métodos del sistema
using System;
using System.Collections;

namespace Hola
{
	public class Flotador
	{
		// Atributos
		private double numero;
		private string signo;		// 1 bit
		private string exponente;	// 8 bits
		private string mantisa;		// 23 bits
		private string representacion;	// 32 bits

		// Métodos
		// Constructor
		public Flotador(double numerul)
		{
			// Asignar el número
			this.numero = numerul;
		}
		public void conversor()
		{
			int i = 0;
			// Generar una lista de tipo entero
			List<int> d = new List<int>();
			double tmp = this.numero;
			// Recorrer el número
			while(true) {
				Console.Write("{0}\t{1:N2}\t", i, tmp);
				d.Add(Convert.ToInt32(Math.Floor(tmp)));
				tmp = (tmp - d[i]) * 2;
				Console.WriteLine("{0}\t{1:N2}", d[i], tmp);
				// TODO: Modificar para asegurar el número de
				// bits
				if((tmp == 0)||(i > 32)) break;
				i++;
			}
			Console.WriteLine(d[0]);
		}
	}

	// Para iniciar el programa
	public class Program
	{
		// Función principal
		public static void Main()
		{
			// TODO: Permitir que el usuario ingrese
			// un valor de punto flotante válido
			// antes de generar el objeto
			Flotador pwise = new Flotador(3.75);
			pwise.conversor();
		}
	}
}
