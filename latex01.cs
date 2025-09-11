// #include
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latex01
{
    // Herencia
    class Vehiculo
    {
        // Atributos
        public string Marca { get; set; }
        public int Anno { get; set; }

        // Métodos
        public void MostrarInfo()
        {
            Console.WriteLine($"{Marca}, Año {Anno}");
        }
    }

    // La clase Combustion, hereda atributos
    // y métodos de la clase Vehiculo
    class Combustion : Vehiculo
    {
        public int CapacidadTanque { get; set; }
    }

    // De la misma forma que la clase Electrico
    class Electrico : Vehiculo
    {
        public int Autonomia { get; set; }
    }

    class Automovil
    {
        /* ATRIBUTOS */
        public int jorspauer;
        public string marca;
        public string modelo;
        public double cilindrada;
        private int anno;
        public int Anno {
            get { return anno; }
            set
            {
                if (value > 0)
                    anno = value;
                else
                    Console.WriteLine("Año no válido");
            } 
        }

        /* GETTERS und SETTERS */
        //public int getAnno() { return anno; }
        //public void setAnno(int valor) { anno = valor; }

        /* MÉTODOS */
        // Constructor
        public Automovil(string mar, string mod, int hp, double cil, int yier)
        {
            marca = mar;
            modelo = mod;
            jorspauer = hp;
            cilindrada = cil;
            Anno = yier;
        }
        public void mostrarInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El Automóvil es {marca} {modelo}");
            Console.WriteLine($"Del año {anno}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar el objeto
            // Clase objeto = new Constructor();
            Automovil cadillac = new Automovil("Cadillac", "Escalade", 600, 6.2, 2025);
            Automovil rayoMcQueen = new Automovil("Chevrolet", "Corvette", 1000, 5.9, -2003);

            cadillac.mostrarInfo();
            rayoMcQueen.mostrarInfo();

            Console.WriteLine(Int64.MaxValue);

            Combustion Vocho = new Combustion { Marca = "VW", Anno = 2004, CapacidadTanque = 40 };
            Electrico Seal = new Electrico { Marca = "BYD", Anno = 2024, Autonomia = 600 };

            Vocho.MostrarInfo();
            Seal.MostrarInfo();

            Console.WriteLine(Vocho.ToString());

        }
    }
}
