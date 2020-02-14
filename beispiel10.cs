using System;

public class Carro
{
	/* Atributos */
	public string modelo;
	public string color;
	public int maxVelocidad;
	public int anno;
	
	/* Métodos */
	
	// Método
	public void fullSpeed()
	{
		Console.WriteLine("El auto " + modelo + " va a la máxima velocidad");
	}
}

public class Program
{

	// Método principal (los métodos estáticos pueden ser ingresados sin crear objetos de clase)
	public static void Main()
	{
		Carro miObj = new Carro();
		miObj.color = "rojo";
		miObj.maxVelocidad = 200;
		
		Console.WriteLine(miObj.color);
		Console.WriteLine(miObj.maxVelocidad);
		
		Carro Ford = new Carro();
		Ford.modelo = "Mustang";
		Ford.color = "rojo";
		Ford.maxVelocidad = 300;
		Ford.anno = 1969;
		
		Carro Opel = new Carro();
		Opel.modelo = "Astra";
		Opel.color = "blanco";
		Opel.maxVelocidad = 220;
		Opel.anno = 2005;
		
		Opel.fullSpeed();
		
	}
}