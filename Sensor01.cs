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
            Sensor temperatura = new Sensor();  // Constructor básico

            Sensor presion = new Sensor(67, "Sensor presión", "psi", 33.0);
        }
    }

    class Sensor
    {
        // ATRIBUTOS
        // Variables que describen al objeto
        // public:  que puede ser visto/modificado en todo el código
        // private: privado, que solamente puede ser modificado en
        //          la propia clase
        private uint id;     // Identificador entero sin signo
        // tipoDato?, le indican que la variable es non-nullable
        // int valor = null;  le están indicando que es un valor nulo
        // char *cadena;
        private string? nombre;
        private string? unidad;
        // Arreglo en C#, guardar 5 datos
        private double[] lecturas;
        private double promedio, maximo, minimo;
        private double umbral;

        // PROPIEDADES
        // Nombrada a partir del atributo
        // iniciando con mayúscula
        // debe ser pública
        // y ha de colocarse:
        public uint Id
        {
            // si es de lectura
            get
            {
                return id;
            }
            // si es de escritura
            // set; // En este caso no puede modificarse
        }

        public string? Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        // MÉTODOS
        // Funciones que describen que hace el objeto
        // Método especial de cada clase
        // Constructor
        public Sensor()
        {
            id = 666;
            nombre = "Sensor genérico chino";
            unidad = "ua";
            lecturas = new double[0];
            umbral = 0.0;
            Console.WriteLine("Objeto genérico construido");
        }

        // Se usa el polimorfismo (no confundir con poliamor)
        // que es que una función puede tener
        // varias funcionalidades sin cambiar su nombre
        // en este caso, la diferencia radica en que se usan diferentes
        // parámetros, para distinguir entre cual constructor usar
        public Sensor(uint id, string nombre, string unidad, double umbral)
        {
            this.id = id;
            this.nombre = nombre;
            this.unidad = unidad;
            this.umbral = umbral;
            lecturas = new double[0];
            Console.WriteLine($"Objeto {this.nombre} construido");
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
