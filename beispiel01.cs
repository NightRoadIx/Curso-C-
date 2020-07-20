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
		
		// Funciones matemáticas
		Console.WriteLine(Math.Max(5,10));		// Máximo
		Console.WriteLine(Math.Min(5,10));		// Mínimo
		Console.WriteLine(Math.Sqrt(81));		// Raíz Cuadrada
		Console.WriteLine(Math.Abs(-54));		// Valor absoluto
		
		Console.ReadKey(true);
	}
}
