using System;
using System.IO;

namespace Program
{
    /// <summary>
    /// Clase estática Restriccion, utilizada para solicitar y validar entradas de datos numéricos del usuario.
    /// </summary>
    public static class Restriccion
    {
        /// <summary>
        /// Solicita un número entero positivo al usuario, repitiendo hasta que la entrada sea válida.
        /// </summary>
        /// <param name="mensaje">El mensaje que se muestra al usuario.</param>
        /// <returns>El valor entero positivo ingresado por el usuario.</returns>
        public static int SolicitarEnteroPositivo(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);

            return valor;
        }

        /// <summary>
        /// Solicita un número real positivo al usuario, repitiendo hasta que la entrada sea válida.
        /// </summary>
        /// <param name="mensaje">El mensaje que se muestra al usuario.</param>
        /// <returns>El valor real positivo ingresado por el usuario.</returns>
        public static double SolicitarRealPositivo(string mensaje)
        {
            double valor;
            do
            {
                Console.Write(mensaje);
            } while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0.0);

            return valor;
        }
    }

    /// <summary>
    /// Clase principal del programa que ejecuta una simulación de caminata aleatoria y guarda los resultados en un archivo CSV.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Punto de entrada principal del programa.
        /// Solicita al usuario el número de pasos y la longitud de cada paso, y luego ejecuta una caminata aleatoria.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos.</param>
        static void Main(string[] args)
        {
            // Solicitar el número de pasos y la longitud de cada paso al usuario.
            int n = Restriccion.SolicitarEnteroPositivo("Ingrese el número de pasos (entero positivo): ");
            double L = Restriccion.SolicitarRealPositivo("Ingrese la longitud de cada paso (número real positivo): ");

            // Iniciar el camino en el origen (0,0)
            double x = 0.0;
            double y = 0.0;

            // Generar el objeto sw de la clase StreamWriter
            // para escribir archivos
            StreamWriter sw = null;
            // Generar el objeto para crear números aleatorios
            Random rnd = new Random();
            double angulo = 0.0;
            try
            {
                // Intentar abrir o crear el archivo CSV para guardar los resultados.
                // Si esta instrucción genera un error, se salta al bloque catch
                sw = new StreamWriter("camino_borracho.nahomi");

                // Escribir encabezados en el archivo CSV.
                sw.WriteLine("i,x,y");

                Console.WriteLine(" i     x       y      a");
                Console.WriteLine("------------------------------");

                // Realizar la caminata aleatoria
                for (int i = 0; i <= n; i++)
                {
                    // Mostrar el paso actual en pantalla.
                    Console.WriteLine($"{i,2}  {x,6:F3}  {y,6:F3}  {convertirAGrados(angulo),6:F2}");

                    // Guardar el paso actual en el archivo CSV.
                    sw.WriteLine($"{i},{x:F3},{y:F3}");

                    // Si no estamos en el último paso, generar el siguiente.
                    if (i < n)
                    {
                        angulo = rnd.NextDouble() * 2 * Math.PI; // Ángulo en [0, 2π]
                        x += L * Math.Cos(angulo);
                        y += L * Math.Sin(angulo);
                    }
                }

                Console.WriteLine("Los resultados han sido guardados en 'camino_borracho.nahomi'");
            }
            catch (IOException e)
            {
                // Captura de errores de entrada/salida y muestra un mensaje de error.
                Console.WriteLine("Ocurrió un error al manejar el archivo: " + e.Message);
            }
            finally
            {
                // Cerrar el archivo si fue abierto correctamente.
                if (sw != null)
                {
                    sw.Close();
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Convertir de radianes a grados
        /// </summary>
        /// <param name="angulo">Ángulo en radianes a convertir</param>
        /// <returns>ángulo convertido en grados</returns>
        static double convertirAGrados(double angulo)
        {
            return (angulo * 180) / Math.PI;
        }
    }
}
