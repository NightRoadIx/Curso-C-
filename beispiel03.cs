using System;
					
public class Program
{
	public static void Main()
	{
		int diaSemana;
		
		Console.WriteLine("Ingrese el día de la semana [1, 7]");
		diaSemana = Convert.ToInt32(Console.ReadLine());
		
		// Instrucción de selección múltiple switch()
		// Debe considerarse que la variable que se pondra a prueba
		// será exactamente igual a cualquiera de las expresiones que se
		// colocan en los casos
		// De preferencia se utilizan valores enteros
		switch(diaSemana)
		{
			case 1:		// Esto sería como if(diaSemana == 1)
				Console.WriteLine("Hoy es Lunes");
				break;	// Esta sentencia rompe el switch y lleva el flujo del programa al fin del switch
			case 2:		// if(diaSemana == 2)
				Console.WriteLine("Hoy es Martes");
				break;
			case 3:
				Console.WriteLine("Hoy es Miércoles");
				break;
			case 4:
				Console.WriteLine("Hoy es Jueves");
				break;
			case 5:
				Console.WriteLine("Hoy es Viernes");
				break;
			case 6:
				Console.WriteLine("Hoy es Sábado");
				break;
			case 7:
				Console.WriteLine("Hoy es Domingo");
				break;
			default:	// Este valor aparece cuando ningún otro elemento es parecido
				Console.WriteLine("Error Mortal en el día seleccionado");
				break;
		}
	}
}