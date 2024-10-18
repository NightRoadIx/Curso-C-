using System;

namespace Biseccion
{
    class Program
    {
        /// <summary>
        /// Evalúa la función f(x) en un valor dado de x.
        /// Puedes cambiar la función según sea necesario.
        /// </summary>
        /// <param name="x">El valor en el que se evaluará la función.</param>
        /// <returns>El resultado de la función evaluada en x.</returns>
        public static double Funcion(double x)
        {
            // Función: -4*x^3 + 6*x^2 + 2*x
            return -4 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) + 2 * x;
        }

        /// <summary>
        /// Implementa el método de bisección para encontrar una raíz de la función en un intervalo dado.
        /// </summary>
        /// <param name="a">Extremo inferior del intervalo.</param>
        /// <param name="b">Extremo superior del intervalo.</param>
        /// <param name="tolerancia">El valor mínimo de la tolerancia para detener el cálculo.</param>
        /// <param name="maxIteraciones">Número máximo de iteraciones permitidas.</param>
        /// <returns>Una aproximación de la raíz encontrada en el intervalo.</returns>
        public static double MetodoBiseccion(double a, double b, double tolerancia, int maxIteraciones)
        {
            // Comprobar que f(a) y f(b) tienen signos opuestos (necesario para el método de bisección)
            if (Funcion(a) * Funcion(b) >= 0)
            {
                // Si no se cumplen los signos opuestos, se muestra un mensaje de error
                Console.WriteLine("Error: La función debe tener signos opuestos en los extremos a y b.");
                return double.NaN;  // Devolver NaN para indicar un error en el cálculo
            }

            double c = a;  // Inicialización de c
            int iteracion = 0;

            // Iterar hasta que se cumpla la condición de tolerancia o se alcancen las iteraciones máximas
            while ((b - a) >= tolerancia && iteracion < maxIteraciones)
            {
                // Calcular el punto medio
                c = (a + b) / 2;

                // Mostrar el progreso de la bisección
                Console.WriteLine($"Iteración {iteracion}: a = {a}, b = {b}, c = {c}, f(c) = {Funcion(c)}");

                // Verificar si c es la raíz
                if (Funcion(c) == 0.0)
                    break;

                // Decidir el nuevo intervalo
                if (Funcion(c) * Funcion(a) < 0)
                    b = c;
                else
                    a = c;

                iteracion++;
            }

            return c; // Aproximación de la raíz
        }

        /// <summary>
        /// Función principal que solicita al usuario los valores para realizar el método de bisección.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Método de bisección para encontrar una raíz de la función -4*x^3 + 6*x^2 + 2*x");

            // Solicitar al usuario los extremos del intervalo
            Console.Write("Introduce el extremo inferior (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el extremo superior (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Solicitar al usuario la tolerancia y las iteraciones máximas
            Console.Write("Introduce la tolerancia deseada: ");
            double tolerancia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el número máximo de iteraciones: ");
            int maxIteraciones = Convert.ToInt32(Console.ReadLine());

            // Calcular la raíz utilizando el método de bisección
            double raiz = MetodoBiseccion(a, b, tolerancia, maxIteraciones);

            // Verificar si se devolvió un valor válido
            if (!double.IsNaN(raiz))
            {
                Console.WriteLine($"Una aproximación de la raíz es: {raiz}");
            }
            else
            {
                Console.WriteLine("No se pudo encontrar una raíz válida en el intervalo proporcionado.");
            }

            Console.ReadKey();
        }
    }
}
