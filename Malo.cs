/*
 * Created by SharpDevelop.
 * User: s_bio
 * Date: 22/03/2022
 * Time: 01:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
// Esta es la librería para la Entrada/Salida de datos
using System.IO;

namespace Malo2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Modificar el nombre de la ventana de consola
			Console.Title = "Malo2";
			
			// Obtener el directorio en donde se está trabajando (path)
			// Ejecutando el programa
			string path = Directory.GetCurrentDirectory();
			// UNDONE: Quitar que se muestre el directorio
			Console.WriteLine("Directorio: {0}", path);
			
			// Generar el directorio auxiliar
			string path2 = path + @"\auxiliar";			
			// Manejo de excepciones para crear el directorio
			try
			{
				// Revisamos si el directorio existe
				if( Directory.Exists(path2) )
					Console.WriteLine("El directorio existe");
				else
				{
					// Intentar crear el directorio
					// instanciar un objeto DirectoryInfo mediante el constructor
					// CreateDirectory(direccion_del_directorio)
					DirectoryInfo infoDir = Directory.CreateDirectory(path2);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("El proceso falló debido a: {0}", e.ToString());
			}
			finally  // UNDONE: Si no es necesario eliminar la parte finally
			{
				Console.WriteLine("<<El programa continua>>");
			}			
			Console.ReadKey(true);
			/*double resultado = 0.0;
			try
			{
				// Estas instrucciones me pueden generar un error en tiempo de
				// ejecución
				for(int i = 10; i >= 0; i--)
				{
					resultado = 10/i;
					Console.WriteLine("Resultado: {0}", resultado);
				}
			}
			catch(Exception e) // Capturar ese error
			{
				Console.WriteLine("El proceso falló debido a: {0}", e.ToString());
			}
			finally
			{
				Console.WriteLine("<<El programa continua>>");
			}			
			Console.ReadKey(true);
			*/
			
			// Recorrer todos los archivos del directorio
			foreach(string arch in Directory.EnumerateFiles(path))
			{
				// Con esto obtenemos el nombre del archivo como tal
				string nombreA = arch.Substring(path.Length + 1);
				
				Console.Clear();
				Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
				// Imprimimos los nombres de los archivos
				Console.WriteLine(nombreA);
				// Leer el contenido de los archivos
				string contenido = File.ReadAllText(arch);
				Console.WriteLine(contenido);
				Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
				
				try
				{
					// Copiar del directorio origen (path) al destino (path2)
					File.Copy( Path.Combine(path, nombreA), Path.Combine(path2, nombreA) );
				}
				catch (Exception e)
				{
					Console.WriteLine("El proceso falló debido a: {0}", e.ToString());
				}
				
				// UNDONE: Eliminar el paso a paso
				Console.WriteLine("Siguiente>>");
				Console.ReadKey(true);
			}
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}