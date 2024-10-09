using System;

namespace Biseccion
{
    class Program
    {
        public static double Funcion(double x)
        {
			// TODO: Completar con la siguiente...
            // Función: -4*x^3 + 6*x^2 + 2*x
			// Y regresar el valor correspondiente
            return x;
        }

        public static double MetodoBiseccion(double a, double b, double tolerancia, int maxIteraciones)
        {
            if (Funcion(a) * Funcion(b) <= 0)
            {
                Console.WriteLine("Error: La función debe tener signos opuestos en los extremos a y b.");
                return double.NaN;  // Devolver NaN para indicar un error en el cálculo
            }

            double c = a;  // Inicialización de c
            int iteracion = 0;

            while ((b - a) >= tolerancia || iteracion < maxIteraciones)
            {
                c = (a + b) / 2;

                Console.WriteLine($"Iteración {iteracion}: a = {a}, b = {b}, c = {c}, f(c) = {Funcion(c)}");

                if (Funcion(c) == 0.0)
                    break;

                if (Funcion(c) * Funcion(a) < 0)
                    b = c;
                else
                    a = c;

                iteracion++;
            }

            return b;
        }

        public static void Main()
        {
            Console.WriteLine("Método de bisección para encontrar una raíz de la función -4*x^3 + 6*x^2 + 2*x");

            Console.Write("Introduce el extremo inferior (a): ");
            double a = Console.ReadLine();

            Console.Write("Introduce el extremo superior (b): ");
            double b = Console.ReadLine();

            Console.Write("Introduce la tolerancia deseada: ");
            double tolerancia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el número máximo de iteraciones: ");
            int maxIteraciones = Convert.ToInt32(Console.ReadLine());

            double raiz = MetodoBiseccion(b, a, tolerancia, maxIteraciones);

            if (!double.IsNaN(raiz))
            {
                Console.WriteLine("Una aproximación de la raíz es: {0}", raiz);
            }
            else
            {
                Console.WriteLine("No se pudo encontrar una raíz válida en el intervalo proporcionado.");
            }

            Console.ReadKey();
        }
    }
}
