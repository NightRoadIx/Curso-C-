using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladoFlotante
{
    /// <summary>
    /// La clase Flotador convierte un número decimal a su representación en coma flotante binaria.
    /// </summary>
    public class Flotador
    {
        // * * * * * * * ATRIBUTOS * * * * * * *

        private double numero;          // Número decimal a convertir en coma flotante.
        private string signo;           // Representa el bit de signo (1 bit).
        private string exponente;       // Representa el exponente (8 bits).
        private string mantisa;         // Representa la mantisa (23 bits).
        private string representacion;  // Representación completa de 32 bits del número en coma flotante.

        // * * * * * * * MÉTODOS * * * * * * *

        /// <summary>
        /// Constructor de la clase Flotador.
        /// Inicializa un objeto con el número decimal proporcionado.
        /// </summary>
        /// <param name="numerul">Número decimal a convertir a representación en coma flotante.</param>
        public Flotador(double numerul)
        {
            // Inicializa el número a convertir.
            this.numero = numerul;
        }

        /// <summary>
        /// Convierte el número decimal en una tabla de conversión paso a paso mostrando cómo se convierte el número a binario.
        /// La tabla incluye iteraciones con el número decimal, su parte entera y fraccionaria en binario.
        /// </summary>
        /// <returns>Una cadena que contiene la tabla con el proceso de conversión paso a paso.</returns>
        public string conversor()
        {
            int i = 0;
            // Generar una lista para almacenar la parte entera del número en cada iteración.
            List<int> d = new List<int>();
            double tmp = this.numero;   // Almacena temporalmente el valor del número para realizar la conversión.
            string tabla = "";          // Tabla que almacenará el resultado paso a paso.
            string linea = "";          // Variable para construir cada fila de la tabla.

            // Ciclo para generar la representación binaria del número en coma flotante.
            while (true)
            {
                // Generar la primera parte de la fila, con el índice y el valor temporal.
                linea = i.ToString() + "\t" + tmp.ToString("N2") + "\t";

                // Almacenar la parte entera de tmp en la lista.
                d.Add(Convert.ToInt32(Math.Floor(tmp)));

                // Actualizar el valor temporal (restar la parte entera y multiplicar por 2).
                tmp = (tmp - d[i]) * 2;

                // Agregar la parte entera y el nuevo valor temporal a la fila.
                linea += d[i].ToString() + "\t" + tmp.ToString("N2");

                // Agregar la línea completa a la tabla.
                tabla += linea + "\n";

                // Condición de parada: cuando la parte fraccionaria es 0 o cuando se han calculado más de 32 iteraciones.
                if ((tmp == 0) || (i > 32)) break;

                i++;
            }
            // Devolver la tabla generada.
            return tabla;
        }
    }

    /// <summary>
    /// Clase principal del programa que inicializa el objeto Flotador y genera la tabla de conversión para un número dado.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Método principal del programa.
        /// Crea un objeto de la clase Flotador y muestra la tabla de conversión binaria paso a paso para un número predefinido.
        /// </summary>
        public static void Main()
        {
            // TODO: Permitir que el usuario ingrese un número en coma flotante válido.

            // Crear un objeto Flotador con el número 21.75 para demostrar la conversión.
            Flotador pwise = new Flotador(21.75);

            // Obtener la tabla de conversión paso a paso.
            string tabla = pwise.conversor();

            // Mostrar la tabla de conversión en la consola.
            Console.Write(tabla);

            // Esperar a que el usuario presione una tecla para cerrar la consola.
            Console.ReadKey();
        }
    }
}
