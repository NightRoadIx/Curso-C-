using System;

namespace CifradoCesarApp
{
    /// <summary>
    /// Clase principal que implementa un cifrado y descifrado sencillo usando el algoritmo de César.
    /// </summary>
    class CifradoCesar
    {
        /// <summary>
        /// Método principal que muestra un menú para encriptar o desencriptar texto desde consola.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("=== Cifrado César ===");
            Console.WriteLine("1. Encriptar texto");
            Console.WriteLine("2. Desencriptar texto");
            Console.Write("Selecciona una opción (1 o 2): ");
            int opcion = int.Parse(Console.ReadLine());

            // Solicita al usuario el texto a procesar
            Console.Write("Introduce el texto: ");
            string texto = Console.ReadLine();

            // Solicita el número de posiciones a desplazar
            Console.Write("Introduce el número de posiciones (desplazamiento): ");
            int desplazamiento = int.Parse(Console.ReadLine());

            string resultado = "";

            // Ejecuta la opción seleccionada por el usuario
            if (opcion == 1)
            {
                resultado = CifrarCesar(texto, desplazamiento);
                Console.WriteLine($"Texto encriptado: {resultado}");
            }
            else if (opcion == 2)
            {
                resultado = DescifrarCesar(texto, desplazamiento);
                Console.WriteLine($"Texto desencriptado: {resultado}");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
            }
        }

        /// <summary>
        /// Aplica el cifrado César a un texto con un número dado de desplazamiento.
        /// </summary>
        /// <param name="texto">Texto original a cifrar.</param>
        /// <param name="desplazamiento">Número de posiciones a desplazar en el alfabeto.</param>
        /// <returns>Texto cifrado.</returns>
        static string CifrarCesar(string texto, int desplazamiento)
        {
            string resultado = "";

            foreach (char caracter in texto)
            {
                if (char.IsLetter(caracter))
                {
                    // Determina si la letra es mayúscula o minúscula para conservar el caso
                    char baseLetra = char.IsUpper(caracter) ? 'A' : 'a';

                    // Calcula el nuevo carácter desplazado en el alfabeto
                    char cifrado = (char)(((caracter - baseLetra + desplazamiento) % 26) + baseLetra);

                    resultado += cifrado;
                }
                else
                {
                    // Si no es una letra (espacio, número o símbolo), se mantiene igual
                    resultado += caracter;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Descifra un texto previamente cifrado con el algoritmo de César.
        /// </summary>
        /// <param name="texto">Texto cifrado que se desea recuperar.</param>
        /// <param name="desplazamiento">El mismo desplazamiento usado al cifrar.</param>
        /// <returns>Texto original descifrado.</returns>
        static string DescifrarCesar(string texto, int desplazamiento)
        {
            // Invertimos el desplazamiento para recuperar el texto original
            return CifrarCesar(texto, 26 - (desplazamiento % 26));
        }
    }
}
