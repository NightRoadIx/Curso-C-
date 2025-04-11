using System;
using System.Text;

namespace CifradoVigenereApp
{
    /// <summary>
    /// Clase que implementa el cifrado y descifrado Vigenère.
    /// </summary>
    class CifradoVigenere
    {
        /// <summary>
        /// Método principal que muestra un menú interactivo para cifrar o descifrar texto.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("=== Cifrado Vigenère ===");
            Console.WriteLine("1. Encriptar texto");
            Console.WriteLine("2. Desencriptar texto");
            Console.Write("Selecciona una opción (1 o 2): ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Introduce el texto (solo letras): ");
            string texto = Console.ReadLine().ToUpper();

            Console.Write("Introduce la clave (solo letras): ");
            string clave = Console.ReadLine().ToUpper();

            string resultado = "";

            if (opcion == 1)
            {
                resultado = CifrarVigenere(texto, clave);
                Console.WriteLine($"Texto cifrado: {resultado}");
            }
            else if (opcion == 2)
            {
                resultado = DescifrarVigenere(texto, clave);
                Console.WriteLine($"Texto descifrado: {resultado}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        /// <summary>
        /// Aplica el cifrado Vigenère al texto usando la clave proporcionada.
        /// </summary>
        /// <param name="texto">Texto original a cifrar (solo letras mayúsculas).</param>
        /// <param name="clave">Clave utilizada para el cifrado (solo letras mayúsculas).</param>
        /// <returns>Texto cifrado.</returns>
        static string CifrarVigenere(string texto, string clave)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                char letraTexto = texto[i];

                if (char.IsLetter(letraTexto))
                {
                    // Repetimos la clave si es más corta que el texto
                    char letraClave = clave[i % clave.Length];

                    // Convertimos letras a posiciones de 0 a 25
                    int posTexto = letraTexto - 'A';
                    int posClave = letraClave - 'A';

                    // Aplicamos la fórmula del cifrado
                    int posCifrado = (posTexto + posClave) % 26;

                    resultado.Append((char)(posCifrado + 'A'));
                }
                else
                {
                    resultado.Append(letraTexto); // Conserva espacios/símbolos (opcional)
                }
            }

            return resultado.ToString();
        }

        /// <summary>
        /// Descifra un texto cifrado con Vigenère usando la clave original.
        /// </summary>
        /// <param name="texto">Texto cifrado (solo letras mayúsculas).</param>
        /// <param name="clave">Clave utilizada para cifrar el texto.</param>
        /// <returns>Texto original descifrado.</returns>
        static string DescifrarVigenere(string texto, string clave)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                char letraTexto = texto[i];

                if (char.IsLetter(letraTexto))
                {
                    char letraClave = clave[i % clave.Length];

                    int posTexto = letraTexto - 'A';
                    int posClave = letraClave - 'A';

                    // Operación inversa del cifrado
                    int posDescifrado = (posTexto - posClave + 26) % 26;

                    resultado.Append((char)(posDescifrado + 'A'));
                }
                else
                {
                    resultado.Append(letraTexto);
                }
            }

            return resultado.ToString();
        }
    }
}
