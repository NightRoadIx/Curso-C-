/*
 * Vamos a simular sensores mágicos y misteriosos
*/
// Esta es la forma de añadir liberías externas al proyecto

// Espacio de nombres, para organizar el código
namespace FiestaPDiddy01
{
    // Clase principal, que contiene el método Main
    class Program
    {
        // Método principal, punto de entrada del programa
        static void Main(string[] args)
        {
            // Crear un objeto a partir de la clase
            // Instanciando un objeto
            // Lo que hace es asignar un espacio en memoria
            // para dicho objeto, que tiene las variables y funciones
            Sensor temperatura = new Sensor();
        }
    }

    class Sensor
    {
        // ATRIBUTOS
        // Variables que describen al objeto
        // public: que puede ser visto/modificado en todo el código
        public uint id;     // Identificador entero sin signo
        // tipoDato?, le indican que la variable es non-nullable
        // int valor = null;  le están indicando que es un valor nulo
        // char *cadena;
        public string? nombre;
        // Arreglo en C#, guardar 5 datos
        public double[] valorTemp = new double[5];
        public double promedio, maximo;

        // MÉTODOS
        // Funciones que describen que hace el objeto
        // Método especial de cada clase
        // Constructor
        public Sensor()
        {
            Console.WriteLine("Objeto construido");
        }

        // TODO: Crear dos funciones o métodos
        // Una para la lectura de los datos y otra para mostrar los datos
    }
}

/*
uint id;
string nombre;

// Arreglo en C#, guardar 5 datos
double[] valorTemp = new double[5];
double promedio, maximo;

for(int i = 0; i < 5; i++)
{
    Console.Write($"Lectura {i + 1}: ");
    while(!double.TryParse(Console.ReadLine(), out valorTemp[i]))
        Console.WriteLine("Dato inválido, intente de nuevo.");
}

// Mostrar los datos ingresados
Console.WriteLine("\nDatos ingresados:");
maximo = valorTemp[0];
foreach(double valor in valorTemp)
{
    Console.WriteLine(valor);
    if(valor > maximo)
        maximo = valor;
}

promedio = valorTemp.Sum() / valorTemp.Length;
Console.WriteLine($"Promedio: {promedio}");
Console.WriteLine($"Máximo  : {maximo}");
*/
