using System;

public class Carro
{
	/* Atributos */
	public string modelo;
	public string color;
	public int maxVelocidad;
	public int anno;
	
	/* Métodos */
	
	// Constructor
	public Carro(string modelName, string modelColor, int modelMaxVel, int modelYear)
	{
		// Aquí puede iniciarse valores por defecto
		/*modelo = "Fiat 500";
		color = "blanco";
		maxVelocidad = 240;
		anno = 2014;*/
		modelo = modelName;
		color = modelColor;
		maxVelocidad = modelMaxVel;
		anno = modelYear;
	}
	
	// Método de máxima velocidad
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
		Carro miObj = new Carro("Fiat 500", "blanco", 220, 2014);
		Console.WriteLine(miObj.color);
		Console.WriteLine(miObj.maxVelocidad);
		
		Carro Ford = new Carro("Mustang", "rojo", 300, 1969);
		/*Ford.modelo = "Mustang";
		Ford.color = "rojo";
		Ford.maxVelocidad = 300;
		Ford.anno = 1969;*/
		
		Carro Opel = new Carro("Astra", "blanco", 220, 2005);
		/*Opel.modelo = "Astra";
		Opel.color = "blanco";
		Opel.maxVelocidad = 220;
		Opel.anno = 2005;*/
		
		// Llamada al método
		Opel.fullSpeed();
		
	}
}