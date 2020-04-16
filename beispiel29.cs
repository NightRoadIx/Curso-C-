using System;

namespace interfaxes
{
	/*
	 * Uso de interfaces
	 * Las interfaces son muy similares a las clases
	 * sin embargo solo contienen declaraciones de los miembros
	 * esto quiere decir que los métodos no contienen una definición
	 * por lo que, una interfaz es como una especie de plantilla
	 * para las clases
	 * */
	
	// Declaración de la interfaz
	interface Vehiculo
	{
		// Todos los métodos de la interfaz
		void cambiarVelocidad(int a);
		void masVelocidad(int a);
		void aplicarFreno(int a);
		void imprimirEstado();
	}
	
	// Clase Bicicleta que implementa la interfaz
	class Bicicleta : Vehiculo
	{
		// Atributos
		private int velocidad;
		private int marcha;
		
		// Métodos
		public void cambiarVelocidad(int nuevaMarcha)
		{
			this.marcha = nuevaMarcha;
		}
		
		public void masVelocidad(int incremento)
		{
			this.velocidad += incremento;
		}
		
		public void aplicarFreno(int decremento)
		{
			this.velocidad -= decremento;
		}
		
		public void imprimirEstado()
		{
			Console.WriteLine("Velocidad: " + this.velocidad + " marcha: " + this.marcha);
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			// TODO: Implement Functionality Here
			// Crear una instancia de Bicicleta
			Bicicleta bici = new Bicicleta();
			
			// Mandar a llamar los métodos
			bici.cambiarVelocidad(4);
			bici.masVelocidad(5);
			bici.aplicarFreno(2);
			
			// Mostrar el estado de la bicicleta
			Console.WriteLine("Estado de la bicicleta: ");
			bici.imprimirEstado();
			
			// Por tanto una interfaz es solo la plantilla para
			// que se puedan definir las funciones en una clase
			// Es una especie de contrato que indica que proporcionará
			// la clase a la aplicación
			
			Console.ReadKey(true);
		}
	}
}