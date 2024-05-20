using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número
        Console.Write("Ingrese un número entero de 32 bits positivo: ");
        int numero = int.Parse(Console.ReadLine());

        // Llamar a la función para mostrar el número separado en sus componentes
        MostrarComponentesI(numero);
    }

    /// <summary>
    /// Función que recibe un número entero positivo y muestra el número separado en sus componentes de unidades.
    /// La forma de generarlo es como una pila
    /// </summary>
    /// <param name="numero">El número entero positivo a ser descompuesto.</param>
    static void MostrarComponentesI(int numero)
    {
        // Lista para almacenar los componentes del número
        List<int> componentes = new List<int>();
        // Factor inicial para extraer los componentes del número
        int factor = 1, digito = 0;

        // Recorrer todo el número
        while (numero > 0)
        {
            // Extraer el 
            // FIXME: Quitar la multiplicación del factor
            // Para obtener sólo la unidad
            digito = (numero % 10) * factor;
            // if (digito != 0) // FIXME: Este elimina el número cuando es 0
            // Insertar al inicio de la lista para mantener el orden
            // Esto es, un estilo LIFO de pila
            componentes.Insert(0, digito);
            // Obtener lo que falta del número
            numero /= 10;
            // Incrementar el factor
            factor *= 10;
        }

        // Mostrar los componentes separados por " + "
        Console.WriteLine(string.Join(" + ", componentes));
    }
}
