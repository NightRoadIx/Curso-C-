using System;

namespace fechizacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Crear un objeto del tipo DateTime
			DateTime fecha = new DateTime();
			// Hay una sobrecarga del constructor que permite crear una fecha
			// especificando año, mes y día
			DateTime fecha2 = new DateTime(1999, 9, 14);
			// Obtener la fecha actual por medio de la clase DateTime
			fecha = DateTime.Now;
			
			// Impirmir la fecha
			Console.WriteLine(fecha.ToString());
			// Obtener solo el día del mes
			Console.WriteLine(fecha.Day.ToString());
			// Día de la semana (en inglés)
			Console.WriteLine(fecha.DayOfWeek);
			// Mes del año
			Console.WriteLine(fecha.Month);
			// Año
			Console.WriteLine(fecha.Year);
			// Hora
			Console.WriteLine(fecha.Hour);
			// Minuto
			Console.WriteLine(fecha.Minute);
			// Segundo
			Console.WriteLine(fecha.Second);
			// Milisegundos
			Console.WriteLine(fecha.Millisecond);
			
			// Métodos
			// Método Compare, compara dos fechas de la siguiente forma:
			int result = DateTime.Compare(fecha, fecha2);
			
			if(result < 0)
				Console.WriteLine("La fecha es menor que la fecha2");
			else if(result == 0)
				Console.WriteLine("Ambas fechas son iguales");
			else
				Console.WriteLine("La fecha es mayor que la fecha2");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}