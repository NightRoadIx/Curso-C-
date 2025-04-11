using System;
using System.Text;

namespace MiniHashDemo
{
    /// <summary>
    /// Demuestra un algoritmo de hash educativo, no criptográfico.
    /// </summary>
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Introduce un texto (ENTER para salir): ");
                string texto = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(texto))
                    break;

                string hash = MiniHash(texto.ToLower());
                Console.WriteLine($"MiniHash: {hash}\n");
            }
        }

        /// <summary>
        /// Convierte un texto en un "hash" educativo basado en suma de letras y posiciones.
        /// </summary>
        /// <param name="entrada">Texto original.</param>
        /// <returns>Valor hash en hexadecimal.</returns>
        static string MiniHash(string entrada)
        {
            int suma = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                char c = entrada[i];

                if (char.IsLetter(c))
                {
                    // Convertimos la letra en su valor (a = 1, ..., z = 26)
                    int valor = c - 'a' + 1;

                    // Multiplicamos por la posición (1-based), sumamos
                    suma += valor * (i + 1);
                }
                else
                {
                    // Si es espacio u otro carácter, lo incluimos como su código ASCII
                    suma += c * (i + 1);
                }
            }

            // Limitamos el valor a algo fijo (como un hash real), usando módulo
            int hashNumerico = suma % 65536;

            // Convertimos a hexadecimal, como un hash real
            return hashNumerico.ToString("X4"); // 4 dígitos hex
        }
    }
}
