/*
 * Unidad Aritmético Lógica en C# 
 * */
using System;

public class Program
{
	public static void Main()
	{
		// Operadores aritméticos
		Console.WriteLine(5 + 9);	// suma
		Console.WriteLine(5 - 9);	// resta
		Console.WriteLine(5 * 9);	// multiplicación
		Console.WriteLine(5 / 9);	// división
		Console.WriteLine(5 % 9);	// módulo o resto de la división
		// Se puede utilizar +=, -=, *=, /=, %= para operar y asignar sobre una variable
		
		// Operadores lógicos (comparación)
		Console.WriteLine(true && true);	// Y (AND)
		Console.WriteLine(false || true);	// O (OR)
		Console.WriteLine(!true);			// NO (NOT)
		
		// Operadores lógicos a nivel de bits
		Console.WriteLine(12 & 10);		//Operador and
		Console.WriteLine(12 | 10);		//Operador or
		Console.WriteLine(12 ^ 10);		//Operador xor
		Console.WriteLine(12 >> 2);		//Operador desplazamiento de bits a la derecha
		Console.WriteLine(12 << 2);		//Operador desplazamiento de bits a la izquierda
		Console.WriteLine(~12);			//Operador NOT para enteros
		// Mostrar la representación en binario de un número entero
		// OJO, este método entrega una cadena de texto
		// no es un número operable como tal
		Console.WriteLine(Convert.ToString(12, 2));
		
		// Funciones matemáticas
		Console.WriteLine(Math.Max(5,10));		// Máximo
		Console.WriteLine(Math.Min(5,10));		// Mínimo
		Console.WriteLine(Math.Sqrt(81));		// Raíz Cuadrada
		Console.WriteLine(Math.Abs(-54));		// Valor absoluto
		Console.WriteLine(Math.Exp(2));			// Exponente (e elevado a)
		// Funciones trigonométricas, operan en radianes
		Console.WriteLine(Math.Cos(3.1416));		// Coseno
		Console.WriteLine(Math.ACos(1));		// Arco coseno
		Console.WriteLine(Math.PI);		// Constante PI
		// Redondear PI a 4 dígitos de precisión
		Console.WriteLine(Math.Round(Math.PI, 4));
		// Pueden ser consultadas en:
		// https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-8.0
		
		Console.ReadKey(true);
	}
}
