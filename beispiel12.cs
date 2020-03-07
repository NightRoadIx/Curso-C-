using System;

namespace cadenosos
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* MÉTODOS DE CADENA */
			// Definimos varias cadenas
			string cadena = "Esta es una cadena de texto laaaaaarga";
			string otra = " y mucho";
			string unamas = " y mucha";
			
			// El atributo "Length" de la clase String, permite obtener la longitud de la cadena de caracteres
			// Se tiene que observar que, se tiene la clase String con un atributo que regresa un entero
			// esto se puede considerar como la clase Entero (Int32) y que tiene como método ToString() que regresa una cadena
			Console.WriteLine("Longitud de la cadena: " + cadena.Length.ToString());
			// Lo siguientes métodos de la clase String, convierten la cadena en:
			// Mayúsculas
			Console.WriteLine( cadena.ToUpper() );
			// Minúsculas
			Console.WriteLine( cadena.ToLower() );
			
			// Las cadenas de texto son simplemente arreglos de caracteres
			Console.WriteLine(cadena[0]);
			
			// El método IndexOf(char), obtiene el índice de la primera ocurrencia del caracter
			Console.WriteLine( cadena.IndexOf("a") );
			// IndexOf() sirve para hallar el índice y aspi usarlo para obtener una subcadena
			// por medio del método Substring()
			Console.WriteLine( cadena.Substring(cadena.IndexOf("l")) );
			
			// Los métodos Compare(string, string)
			// y Equals(string, string)
			// comparan 2 cadenas, regresando un entero (Compare())
			// o un booleano (Equals())
			Console.WriteLine( String.Compare(otra, unamas).ToString() );
			Console.WriteLine( String.Equals(otra, unamas).ToString() );
			
			// El método Remove(int indice, int num), remueve de una cadena a partir
			// del índice y un num de caracteres
			Console.WriteLine( cadena.Remove(18,9) );
			
			// el método Replace(char base, char camb) busca el caracter base y lo reemplaza con camb
			Console.WriteLine( cadena.Replace(' ', ',') );
			
			// el método Split(char[]), separa una cadena de caracteres, tomando en consideración 
			// el arreglo de char[] y se obtiene un arreglo de strings
			string[] sep = cadena.Split(new Char [] {' ', ','});
			// Se recorre entonces con un foreach()
			foreach(string s in sep)
				Console.WriteLine(s);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}