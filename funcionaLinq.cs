namespace ErikErikson
{
    public class Program
    {
        /// <summary>
        ///  Indica si un número es par
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        // Generar una función que, mediante recursividad
        // calcule el factorial de un número entero positivo
        static int Factorial(int numero)
        {
            // Este es el método de paro
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                // Aquí se manda a llamar a a función
                return numero * Factorial(numero - 1);
            }
        }

        static void Main(string[] args)
        {
            int[] numeros = {4, 8, 15, 16, 23, 42, 69};

            // Generar un enumerable que indique que números
            // de la lista son pares
            // Aquí se manda a llamar a la función EsPar para filtrar los números pares
            // como parámetro del método Where
            var pares = numeros.Where(EsPar);
            // Mostrar los números pares
            foreach (var par in pares)
            {
                Console.WriteLine(par);
            }

            // Por otro lado, se puede calcular el factorial de un número entero positivo
            int numero = 5;
            int resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es {resultado}");
        }
    }
}
