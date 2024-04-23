// Esto sustituye al #include <> en C
// Permite usar atributos y métodos del sistema
using System;
using System.Collections;
using System.IO;	// Trabajar con entrada/salida
using System.Globalization;

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
		public string conversor()
		{
			int i = 0;
			// Generar una lista de tipo entero
			List<int> d = new List<int>();
			double tmp = this.numero;
			string tabla = "";
			string linea = "";
			DateTime fecha = new DateTime();
			// Generar un manejador de contexto para
			// escribir en un archivo línea por línea
			using (StreamWriter fs = new StreamWriter("islas4.txt"))
			{
				// Recorrer el número
				while(true) {
					// Obtener el tiempo en ese momento
					fecha = DateTime.Now;
					// Generar la primera parte de la fila
					linea = fecha.ToString() + "\t" + i.ToString() + "\t" + tmp.ToString("N2") + "\t";
					d.Add(Convert.ToInt32(Math.Floor(tmp)));
					tmp = (tmp - d[i]) * 2;
					// Lo que continua con la fila
					linea += d[i].ToString() + "\t" + tmp.ToString("N2");
					// Se va creando la tabla
					tabla += linea + "\n";
					// Escribir la línea en el archivo
					fs.WriteLine(linea);
					// TODO: Modificar para asegurar el número de
					// bits
					if((tmp == 0)||(i > 32)) break;
					i++;
				}
			}
			Console.WriteLine(d[0]);
			return tabla;
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
			Flotador pwise = new Flotador(0.3);
			string tabla = pwise.conversor();
			//File.WriteAllText("islas2.txt", tabla);
			Console.Write(tabla);

			//string islas = "Ya me quiero dar de baja de la bida\nHola a todos!";
			//File.WriteAllText("reversa.txt", islas);
		}
	}
}
