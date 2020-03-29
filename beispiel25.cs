using System;

namespace programa
{
	
	public class Coso
	{
		// Atributo que es privado (encapsulado)
		private string nombre;
		
		// Ahora el atributo que modificará la propiedad
		// Se puede llamar de la misma forma que el atributo privado, pero iniciando con mayúsucula
		public string Nombre
		{
			get{
				return nombre;
			}
			set{
				// Aquí se manda a asignar mediante la palabra value, que será un valor que reciba
				this.nombre = value;
			}
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			// Instnciar un objeto
			Coso s = new Coso();
			
			// Para asignar el valor se puede usar lo siguiente
			// que es muy similar a utilizar la función set
			s.Nombre = "Dr. Who";
			
			// Y ahora para ver el contenido  
			Console.WriteLine("El nombre es: " + s.Nombre);
				
			Console.ReadKey();
		}
	}
}