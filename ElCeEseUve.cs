using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Globalization;

namespace programa
{
    class ElCeEseUve
    {

    		/* Función para obtener el contenido de un archivo de una URl en formato de cadena de texto */
    		public static string obtenerCSV(string url)
    		{
    			// Se crea el pedido de una URL
    			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
    			// Aquí es donde se manejará la respuesta que entregue esta URL
    			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
    			
    			// Depués se crea un "streaming" para la lectura "en directo" del archivo solicitado
    			StreamReader sr = new StreamReader(resp.GetResponseStream());
    			// Se leerá el archivo hasta el final para asignarlo a una cadena de texto
    			string results = sr.ReadToEnd();
    			// IMPORTANTRE: Cerrar el streaming de lectura
    			sr.Close();
    			
    			return results;
    		}

        /* Función para la lectura línea por línea de un archivo CSV */
        public static void leerCSV(string url)
        {
            int j = 0;
            int k = 0;

			// Se crea el pedido de una URL
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			// Aquí es donde se manejará la respuesta que entregue esta URL
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            // Leer por medio de un StreamReader y un manejador de contexto
            // using() el cual es una especie de try - catch()
            // para evitar que no ejecuten algunas instrucciones, además
            // de encargarse de abrir y cerrar el recurso
            using(var letor = new StreamReader(resp.GetResponseStream()))
            {
                // Para almacenar los encabezados de las columnas
                string[] encabeza = {};

                // Mientras que no se llegue a final de archivo
                while(!letor.EndOfStream)
                {
                    // Lectura línea por línea
                    var linia = letor.ReadLine();
                    // Se separan los datos usando como delimitador un punto y coma (;)
                    // ESTE EJEMPLO ASÍ SE ESTÁ MANEJANDO, GENERALMENTE SE TRATA DE UNA ,
                    string[] valores = linia.Split(';');                    
                    // La primera será (o debe ser los encabezados)
                    if(j == 0)
                    {
                        encabeza = linia.Split(";");
                        // Obtener la cantidad de datos
                        k = valores.Length;
                    }

                    // Incrementar el número de líneas leídas
                    j++;
                }

                Console.WriteLine("\n\nSe han leído: {0} líneas", j+1);
                Console.WriteLine("Con {0} columnas", k);
                Console.WriteLine("Cuyo encabezado es: ");
                foreach(string valor in encabeza)
                    Console.Write(" {0} ", valor);
            }
        }

        public static void Main(string[] args)
        {
            // Un CSV Ejemplo 
            string url = obtenerCSV("https://support.staffbase.com/hc/en-us/article_attachments/360009197031/username.csv");
            // Observar todo el archivo como un conjunto
            Console.WriteLine(url);

            // Leer el CSV línea a línea
            leerCSV("https://support.staffbase.com/hc/en-us/article_attachments/360009197031/username.csv");
        }
    }
}
