using System;

namespace programa
{
		
	class Program
	{
		
		/*
		 * Enumeraciones
		 * Las enumeraciones funcionan como en lenguaje C, que es utilizada principalmente
		 * para asignar nombres o valores de cadena a constantes enteras, lo cual vuelve a los
		 * programas, sencillos de leer y mantener
		 * Por ejemplo, se puede asignar los nombres de los planetas, días de la semana, colores 
		 * del arcoiris, etc.
		 */ 
		enum planeten
		{
			Mercurio,
			Venus,
			Tierra,
			Marte,
			Júpiter,
			Saturno,
			Urano,
			Plutón // Así es, me vale, para mi Plutón sigue siendo planeta
		} // las enumeraciones deben de ser atributos de clase
		
		public static void Main(string[] args)
		{
			/*
			 * Variable tipada implícita
			 * El uso del tipo implícito "var" permite crear variables sin necesidad de especificar
			 * de manera explícita el tipo, ya que será automáticamente deducida en tiempo de compilación
			 * Solo debe usarse como variable local
			 * No debe utilizarse ni como parámetro ni como valor de retorno en los métodos
			 */
			var imp = 15;
			Console.WriteLine("La variable {0}", imp);
			Console.WriteLine("El tipo de variable es {0}", imp.GetType() );
			

			// Uso de las enumeraciones (ver que se transforma a String para ver el valor y se hace "cast" en entero para ver el valor)
			Console.WriteLine("El valor de {0} en la enumeración es {1}", planeten.Marte.ToString(), (int)planeten.Marte );
			
			// Se puede usar un foreach para ver todos los miembros de una enumeración
			// Se debe observar que se tiene que utilizar la clase Enum, que posee un método GetNames() el cual recibe como 
			// parámetro el tipo de la enumeración que se desea observar
			foreach(string k in Enum.GetNames(typeof(planeten)))
				Console.Write(k + " ");
			
			Console.ReadKey();
		}
	}
}