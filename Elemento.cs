using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemento
{
    /// <summary>
    /// Clase que representa un elemento químico de la tabla periódica.
    /// </summary>
    public class Elemento
    {
        // * * * * * * * ATRIBUTOS * * * * * * *
        // Atributos privados para asegurar la encapsulación.

        private string nombre;        // Nombre del elemento químico.
        private string simbolo;       // Símbolo del elemento químico.
        private int numeroAtomico;    // Número atómico del elemento.
        private double pesoAtomico;   // Peso atómico del elemento.

        /* MÉTODOS */
        /// <summary>
        /// Constructor por defecto.
        /// Muestra un mensaje indicando que un nuevo elemento químico ha sido creado.
        /// </summary>
        public Elemento()
        {
            Console.WriteLine("Un nuevo elemento químico ha sido creado.");
        }

        /// <summary>
        /// Constructor que inicializa un elemento químico con los valores proporcionados.
        /// </summary>
        /// <param name="nombre">Nombre del elemento químico.</param>
        /// <param name="simbolo">Símbolo del elemento químico.</param>
        /// <param name="numeroAtomico">Número atómico del elemento.</param>
        /// <param name="pesoAtomico">Peso atómico del elemento.</param>
        public Elemento(string name, string symbol, int atomicNumber, double atomicWeight)
        {
            // Esto es el polimorfismo, el cual permite generar métodos con el mismo
            // nombre dentro de una clase, pero con comportamientos diferentes
            this.nombre = name;
            this.simbolo = symbol;
            this.numeroAtomico = atomicNumber;
            this.pesoAtomico = atomicWeight;
            Console.WriteLine(" Se creó el elemento " + this.nombre);
        }

        /// <summary>
        /// Método que permite al usuario ingresar los datos del elemento químico desde el teclado.
        /// Solicita el nombre, símbolo, número atómico y peso atómico.
        /// Se asegura que el número y peso atómicos sean válidos.
        /// </summary>
        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa la información del elemento químico:");

            Console.Write("Nombre: ");
            this.nombre = Console.ReadLine();

            Console.Write("Símbolo: ");
            this.simbolo = Console.ReadLine();

            // Validación para asegurar que el número atómico ingresado sea un entero positivo.
            Console.Write("Número atómico: ");
            int numAtom;
            while (!int.TryParse(Console.ReadLine(), out numAtom) || numAtom <= 0)
            {
                Console.WriteLine("Por favor, ingresa un número atómico válido (entero positivo).");
            }
            this.numeroAtomico = numAtom;

            // Validación para asegurar que el peso atómico ingresado sea un valor positivo.
            Console.Write("Peso atómico: ");
            double pesAtom;
            while (!double.TryParse(Console.ReadLine(), out pesAtom) || pesAtom <= 0)
            {
                Console.WriteLine("Por favor, ingresa un valor de peso atómico válido (positivo).");
            }
            this.pesoAtomico = pesAtom;
        }

        /// <summary>
        /// Método que muestra la información del elemento químico en la consola.
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine("\nInformación del elemento:");
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Símbolo: {0}", this.simbolo);
            Console.WriteLine("Número atómico: {0}", this.numeroAtomico);
            Console.WriteLine("Peso atómico: {0}", this.pesoAtomico);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar un objeto de clase Elemento
            Elemento hidrogene = new Elemento();
            // Instanciar otro objeto con el constructor que recibe parámetros
            Elemento helio = new Elemento("Helio", "He", 2, 2.0016);

            // Ingresar los datos del objeto hidrogene
            hidrogene.IngresarDatos();

            // Mostrar los datos
            hidrogene.MostrarInformacion();
            helio.MostrarInformacion();

            Console.ReadKey();
        }
    }

}
