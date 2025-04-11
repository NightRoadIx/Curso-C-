using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnalisisFrecuencia
{
    /// <summary>
    /// Clase principal que realiza análisis de frecuencia sobre texto descargado desde Internet.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Punto de entrada del programa.
        /// </summary>
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Análisis de Frecuencia de Letras ===");
            Console.Write("Ingresa la URL del texto (ej: Romeo y Julieta): ");
            string url = Console.ReadLine();
            // https://www.gutenberg.org/cache/epub/1112/pg1112.txt
            // https://www.gutenberg.org/cache/epub/2000/pg2000.txt

            Console.WriteLine("\nDescargando texto...");
            string texto = await DescargarTexto(url);

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("No se pudo descargar el texto.");
                return;
            }

            Console.WriteLine("Analizando frecuencia de letras...\n");
            var frecuencias = AnalizarFrecuencia(texto);

            // Mostrar resultados ordenados por frecuencia
            foreach (var par in frecuencias.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{par.Key}: {par.Value} apariciones");
            }
        }

        /// <summary>
        /// Descarga el contenido de texto desde una URL dada.
        /// </summary>
        /// <param name="url">URL del archivo de texto.</param>
        /// <returns>Texto completo como string.</returns>
        static async Task<string> DescargarTexto(string url)
        {
            try
            {
                using HttpClient client = new HttpClient();
                string contenido = await client.GetStringAsync(url);
                return contenido;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descargar: {ex.Message}");
                return "";
            }
        }

        /// <summary>
        /// Analiza y cuenta la frecuencia de letras A–Z en un texto dado (ignora acentos).
        /// </summary>
        /// <param name="texto">Texto a analizar.</param>
        /// <returns>Diccionario con letra y frecuencia.</returns>
        static Dictionary<char, int> AnalizarFrecuencia(string texto)
        {
            var frecuencias = new Dictionary<char, int>();

            // Solo letras, eliminamos tildes, pasamos a mayúsculas
            texto = RemoverTildes(texto.ToUpper());

            foreach (char c in texto)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    if (!frecuencias.ContainsKey(c))
                        frecuencias[c] = 0;
                    frecuencias[c]++;
                }
            }

            return frecuencias;
        }

        /// <summary>
        /// Remueve tildes de vocales acentuadas para un análisis estándar.
        /// </summary>
        /// <param name="entrada">Texto original.</param>
        /// <returns>Texto sin tildes.</returns>
        static string RemoverTildes(string entrada)
        {
            return entrada
                .Replace("Á", "A")
                .Replace("É", "E")
                .Replace("Í", "I")
                .Replace("Ó", "O")
                .Replace("Ú", "U")
                .Replace("Ñ", "N"); // opcional, para incluir la Ñ o no
        }
    }
}
