namespace Traviesos
{
    public class Program
    {
        static private double[] lecturas;

        // Aquí se genera una función que valide si un valor está dentro de un rango permitido
        static void ValidarRango(double valor, double min, double max)
        {
            // Si el valor está fuera del rango permitido, se lanza una excepción
            if (valor < min || valor > max)
            {
                // Se lanza una excepción de tipo ArgumentOutOfRangeException
                throw new ArgumentOutOfRangeException(nameof(valor), 
                $"El valor está fuera del rango permitido [{min}, {max}].");
            }
        }

        static void CargarLecturas(double[] valores)
        {
            if(valores == null)
                throw new ArgumentNullException(nameof(valores), "El arreglo de valores no puede ser nulo.");

            if(valores.Length == 0)
                throw new ArgumentException("El arreglo de valores no puede estar vacío.", nameof(valores));

            lecturas = valores.ToArray();
        }

        static void Main(string[] args)
        {
            int[] numeros = {4, 8, 15, 16, 23, 42, 69};

           // Usar la excepción de validar rango para verificar si un valor está dentro de un rango permitido
            double valor = 10.5;
            double min = 0.0;
            double max = 10.0;

            // Se utiliza un bloque try-catch para capturar la excepción si el valor está fuera del rango permitido
            try
            {
                // Se manda a llamar a la función ValidarRango para verificar si el valor está dentro del rango permitido
                ValidarRango(valor, min, max);
                // Se llega a este punto si el valor está dentro del rango permitido
                Console.WriteLine($"El valor {valor} está dentro del rango permitido [{min}, {max}].");
            }
            // Se captura la excepción ArgumentOutOfRangeException si el valor está fuera del rango permitido
            catch (ArgumentOutOfRangeException ex)
            {
                // Aquí se maneja la excepción y se muestra un mensaje indicando que el valor está fuera del rango permitido
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Este bloque se ejecuta siempre, independientemente de si se lanzó o no una excepción
                Console.WriteLine("Validación de rango completada.");
            }

            // Probar la lectura de archivos
            // Considerando que se pueden generar excepciones al leer archivos, se puede utilizar un bloque try-catch para capturar la excepción si el archivo no existe
            try
            {
                // Se manda a llamar a la función CargarLecturas para leer los valores de un archivo
                CargarLecturas(null);
            }
            catch (ArgumentNullException ex)
            {
                // Aquí se maneja la excepción y se muestra un mensaje indicando que el arreglo de valores no puede ser nulo
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Aquí se maneja la excepción y se muestra un mensaje indicando que el arreglo de valores no puede estar vacío
                Console.WriteLine(ex.Message);
            }

            // Una forma adecuada de pedir o leer datos
            while(true)
            {
                try
                {
                    Console.Write("Ingrese un valor numérico: ");
                    valor = double.Parse(Console.ReadLine());
                    break; // Si la conversión es exitosa, se sale del bucle
                }
                catch (FormatException)
                {
                    // Aquí se maneja la excepción y se muestra un mensaje indicando que el valor ingresado no es un número válido
                    Console.WriteLine("El valor ingresado no es un número válido. Intente de nuevo");
                    continue; // Se pide de vuelta el dato
                }
            }
        }
    }
}
