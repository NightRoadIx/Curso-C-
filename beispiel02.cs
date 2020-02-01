using System;
					
public class Program
{
	public static void Main()
	{
		int a, b;
		Console.WriteLine("Ingrese valor a: ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese valor b: ");
		b = Convert.ToInt32(Console.ReadLine());
		
		// Sentencia de decisión if() - else if() - else
		// Permite seleccionar entre tres opciones
		// Por ejemplo, comparar entre dos números
		if (a > b)		// Verifica que a sea mayor que b
		{
			Console.WriteLine("El número {0} es mayor que {1}", a, b);
		}
		else if(a < b)	// En otro caso, verifica que a sea menor que b
		{
			Console.WriteLine("El número {0} es mayor que {1}", b, a);
		}
		else			// Finalmente si ninguna de las condiciones se cumplen
		{
			Console.WriteLine("Ambos números son iguales");
		}
		
		// Operador ternario
		int edad;
		Console.WriteLine("Ingrese su edad: ");
		edad = Convert.ToInt32(Console.ReadLine());
		// El operador ternario es resultado = (condicion) ? expresión_verdadera : expresión_falsa
		// En este caso se asigna una cadena de texto dependiendo del valor de edad
		// Esto sustituye a:
		/*
			if(condicion)
				resultado = expresión_verdadera
			else
				resultado = expresión_falsa
			
			Condensando el código fuente a su mínima expresión
		*/
		string resultado = (edad < 18) ? "menor" : "mayor";
		Console.WriteLine("Es {0} de edad", resultado);
		
	}
}