using System;
using System.Diagnostics;

namespace complejida
{
    class Complejida
    {
        public static void Ouno(int n)
        {
            // Esta función imprime el valor 5.
            // Parámetros:
            //   n: El valor de entrada (no se utiliza en esta función).
            // Retorna: Nada.
            // Excepciones: Ninguna.
            // Complejidad: O(1)
            int resultado = 5;
            Console.WriteLine("Resultado: " + resultado);
        }

        public static int Oene(int[] arreglo)
        {
            // Esta función calcula la suma de los elementos en un arreglo.
            // Parámetros:
            //   arreglo: Arreglo de enteros.
            // Retorna: La suma de los elementos del arreglo.
            // Excepciones: Ninguna.
            // Complejidad: O(n)
            int suma = 0;
            foreach(int num in arreglo)
                suma += num;
            return suma;
        }

        public static int BinarySearch(int[] arreglo, int n)
        {
            // Esta función realiza una búsqueda binaria en un arreglo ordenado.
            // Parámetros:
            //   arreglo: Arreglo de enteros ordenado.
            //   n: Valor a buscar en el arreglo.
            // Retorna: El índice del valor buscado si se encuentra, de lo contrario retorna -1.
            // Excepciones: Ninguna.
            // Complejidad: O(log n)
            int izq = 0;
            int der = arreglo.Length - 1;
            while(izq <= der)
            {
                int med = izq + (der - izq) / 2;
                if(arreglo[med] == n)
                    return med;
                else if(arreglo[med] < n)
                    izq = med + 1;
                else
                    der = med - 1;
            }
            return -1;
        }

        public static void BubbleSort(int[] arreglo)
        {
            // Esta función ordena un arreglo utilizando el algoritmo de Bubble Sort.
            // Parámetros:
            //   arreglo: Arreglo de enteros a ordenar.
            // Retorna: Nada.
            // Excepciones: Ninguna.
            // Complejidad: O(n^2)
            int n = arreglo.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if(arreglo[j] > arreglo[j + 1])
                    {
                        int tmp = arreglo[j];
                        arreglo[j] = arreglo[j+1];
                        arreglo[j+1] = tmp;
                    }
                }
            }
        }

        public static void swap(int[] arreglo, int i, int j)
        {
            // Esta función intercambia dos elementos en un arreglo.
            // Parámetros:
            //   arreglo: Arreglo de enteros.
            //   i: Índice del primer elemento a intercambiar.
            //   j: Índice del segundo elemento a intercambiar.
            // Retorna: Nada.
            // Excepciones: Ninguna.
            int tmp = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = tmp;
        }

        public static int particion(int[] arreglo, int bajo, int alto)
        {
            // Esta función particiona un arreglo para el algoritmo QuickSort.
            // Parámetros:
            //   arreglo: Arreglo de enteros.
            //   bajo: Índice más bajo del rango a considerar.
            //   alto: Índice más alto del rango a considerar.
            // Retorna: El índice del pivote después de la partición.
            // Excepciones: Ninguna.
            int pivote = arreglo[alto];
            int i = bajo - 1;

            for(int j = bajo; j < alto; j++)
            {
                if(arreglo[j] < pivote)
                {
                    i++;
                    swap(arreglo, i, j);
                }
            }
            swap(arreglo, i + 1, alto);
            return i + 1;
        }

        public static void quicksort(int[] arreglo, int bajo, int alto)
        {
            // Esta función ordena un arreglo utilizando el algoritmo QuickSort.
            // Parámetros:
            //   arreglo: Arreglo de enteros a ordenar.
            //   bajo: Índice más bajo del rango a considerar.
            //   alto: Índice más alto del rango a considerar.
            // Retorna: Nada.
            // Excepciones: Ninguna.
            // Complejidad: O(n log n)
            // En el peor de los casos O(n^2)
            if(bajo < alto)
            {
                // Encuentra el ínidice del pivote después de la partición
                int pivoteIndice = particion(arreglo, bajo, alto);

                // Ordenar recursivamente los elementos antes y después del pivote
                quicksort(arreglo, bajo, pivoteIndice - 1);
                quicksort(arreglo, pivoteIndice + 1, alto); 
            }
        }

        public static long Factorial(int n)
        {
            // Parámetros:
            //   n: Número a revisar el factorial.
            // Retorna: Valor del factorial del número n!.
            // Excepciones: Ninguna.
            // Complejidad: O(n)
            if (n == 0)
                // Caso base: el factorial de 0 es 1
                return 1;
            // Caso recursivo: fatorial(n) = n * fatorial(n - 1)
            return n * Factorial(n - 1);
        }

        public static double Fibonacci(int n)
        {
            // Función para calcular el término n de la serie de Fibonacci.
            // Parámetros:
            //   n: El índice del término de la serie de Fibonacci.
            // Retorna: El valor del término n de la serie de Fibonacci.
            // Excepciones: Ninguna.        
            // Complejidad: O(2^n)
            if (n <= 1)
                // Caso base: los primeros dos términos de Fibonacci son 1
                return 1;
            // Caso recursivo: fibonacci(n) = fibonacci(n - 1) + fibonacci(n - 2)
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int[] GenerateRandomArray(int size)
        {
			// Función para generar un arreglo aleatorio de enteros.
			// Parámetros:
			//   size: Tamaño del arreglo a generar.
			// Retorna:
			//   Un arreglo de enteros aleatorios.
			// Excepciones: Ninguna.
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(1000); // Genera números aleatorios entre 0 y 999.
            return arr;
        }

        // Función para mostrar un arreglo
        public static void mostrarArreglo(int[] arr)
        {
            foreach(int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Función para escribir datos en un archivo CSV.
        /// </summary>
        /// <param name="filePath">Ruta del archivo CSV.</param>
        /// <param name="i">Valor de la variable i.</param>
        /// <param name="n">Tamaño del arreglo.</param>
        /// <param name="ticks">Ticks de tiempo transcurrido.</param>
        public static void WriteToCSV(string filePath, int i, int n, long ticks)
        {
            // Crear un nuevo archivo o sobrescribir si ya existe
            using (StreamWriter writer = new StreamWriter(filePath, true))
                // Escribir el encabezado
                writer.WriteLine(i + "," + n + "," + ticks);
        }

        public static void Main(string[] args)
        {
            // Ruta y nombre del archivo CSV
            string archivo = "datosEjecucion2.csv";

            // Crear o sobreescribir el archivo CSV
            // Escribir el encabezado
            File.WriteAllText(archivo, "i,n,ticks\n");

            // Iniciar un contador para el índice de la tabla
            int j = 1; 
            // Recorrer los datos
            for(int i = 1; i <= 1000; i+=50, j++)
            {
                // Generar un arreglo aleatorio de tamaño i
                int[] arreglo = GenerateRandomArray(i);
                mostrarArreglo(arreglo);

                // Medir el tiempo de ejecución de la función BubbleSort
                // Crear el objeto Stopwatch
                Stopwatch stopwatch = new Stopwatch();
                // Iniciar el cronómetro
                stopwatch.Start();
                // Función a analizar
                quicksort(arreglo, 0, arreglo.Length-1);
                // Detener el cronómetro
                stopwatch.Stop();
                mostrarArreglo(arreglo);

                // Medir los ticks de cuanto tardan las funciones
                long ticks = stopwatch.ElapsedTicks;
                // Escribir en el CSV
                WriteToCSV(archivo, j, i, ticks);
                Console.WriteLine("Tiempo: " + ticks + " ticks");
            }
        }
    }
}
