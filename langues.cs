using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Lista para almacenar los dígitos del número
    static List<int> digitos = new List<int>();

    // Diccionario para almacenar los nombres de los números en diferentes idiomas
    static Dictionary<string, string> nombresBase = new Dictionary<string, string>();

    // Ruta del archivo CSV que contiene los nombres de los números
    static string ruta = "numeros.csv";

    /// <summary>
    /// Muestra un menú con opciones para seleccionar el idioma en el que se desea ver el nombre del número.
    /// </summary>
    static void mostrarMeny()
    {
        // Comprobar que el archivo existe
        if (File.Exists(ruta))
        {
            Console.WriteLine("Opciones para mostrar nombre: ");
            using (StreamReader lectorArchivo = new StreamReader(ruta))
            {
                string linea;
                int numere = 0, j = 0, opc = 0;

                // Recorrer todo el archivo
                while ((linea = lectorArchivo.ReadLine()) != null)
                {
                    // Dividir la línea en valores individuales
                    // Usando como separador la ","
                    string[] valores = linea.Split(",");

                    // Revisar el encabezado solamente
                    if (j == 0)
                    {
                        // Mostrar los valores del encabezado como menú
                        foreach (string val in valores)
                        {
                            if (numere != 0)
                                Console.WriteLine($"{numere}. {val}");
                            numere++;
                        }

                        // Obtener la opción del usuario
                        Console.Write("Opción-> ");
                        opc = obtenerCaracter(numere - 1);

                        // Cambia el estado para procesar los nombres
                        j = 1;
                    }
                    else
                    {
                        // Cargar los nombres en el diccionario correspondiente
                        nombresBase.Add(valores[0], valores[opc]);
                    }
                }
            }
        }
        else
            Console.WriteLine("El archivo no existe");
    }

    /// <summary>
    /// Solicita al usuario que ingrese una opción válida y la devuelve.
    /// </summary>
    /// <param name="maxValor">El valor máximo que puede ser seleccionado.</param>
    /// <returns>La opción seleccionada por el usuario.</returns>
    static int obtenerCaracter(int maxValor)
    {
        int opc;
        while (true)
        {
            // Leer el número y convertir a int, revisar que esté en el intervalo
            if ((Int32.TryParse(Console.ReadLine(), out opc)) && ((opc > 0) && (opc <= maxValor)))
                return opc;
        }
    }

    /// <summary>
    /// Obtiene los nombres de los dígitos en el idioma seleccionado.
    /// </summary>
    /// <returns>El nombre completo del número en el idioma seleccionado.</returns>
    static string obtenerNombre()
    {
        Console.WriteLine($"{digitos.Count}");
        foreach (int val in digitos)
        {
            Console.WriteLine($"{val} {nombresBase[val.ToString()]}");
        }
        return "";
    }

    /// <summary>
    /// Función que recibe un número entero positivo y muestra el número separado en sus componentes de unidades.
    /// La forma de generarlo es como una pila.
    /// </summary>
    /// <param name="numero">El número entero positivo a ser descompuesto.</param>
    static void MostrarComponentesI(int numero)
    {
        // Lista para almacenar los componentes del número
        List<int> componentes = new List<int>();
        // Factor inicial para extraer los componentes del número
        int factor = 1, digito = 0, digit0 = 0;

        // Recorrer todo el número
        while (numero > 0)
        {
            // Extraer la unidad y calcular el componente
            digit0 = numero % 10;
            digito = digit0 * factor;

            // Insertar al inicio de la lista para mantener el orden
            componentes.Insert(0, digito);
            digitos.Insert(0, digit0);

            // Obtener lo que falta del número
            numero /= 10;

            // Incrementar el factor
            factor *= 10;
        }

        // Mostrar los componentes separados por " + "
        Console.WriteLine(string.Join(" + ", componentes));
    }

    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número
        Console.Write("Ingrese un número entero de 32 bits positivo: ");
        int numero = int.Parse(Console.ReadLine());

        // Llamar a la función para mostrar el número separado en sus componentes
        MostrarComponentesI(numero);

        // Mostrar el menú y obtener la correspondiente lista de nombres
        mostrarMeny();

        // Obtener los nombres
        string nombreFinal = obtenerNombre();
    }
}
// =D
