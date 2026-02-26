using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Inicializamos el generador de números aleatorios
        Random rnd = new Random();

        // Lista de sensores con sus valores aleatorios
        List<(string Sensor, double Lectura)> sensores = new List<(string, double)>();

        // Generar 20 lecturas aleatorias
        for (int i = 0; i < 20; i++)
        {
            string sensorTipo = "";
            switch(i % 4)
            {
                case 0:
                    sensorTipo = "Motor";
                    break;
                case 1:
                    sensorTipo = "Temperatura";
                    break;
                case 2:
                    sensorTipo = "Velocidad";
                    break;
                case 3:
                    sensorTipo = "Oxigenación";
                    break;                                                       
            }

            double lectura = sensorTipo switch
            {
                "Motor" => rnd.Next(1000, 8000), // RPM motor entre 1000 y 8000
                "Temperatura" => Math.Round(rnd.NextDouble() * (120 - 20) + 20, 2), // Temperatura entre 20 y 120 °C
                "Velocidad" => Math.Round(rnd.NextDouble() * (200 - 0) + 0, 2), // Velocidad entre 0 y 200 km/h
                "Oxigenación" => Math.Round(rnd.NextDouble() * (100 - 90) + 90, 2), // Oxigenación entre 90% y 100%
                _ => 0.0
            };

            sensores.Add((sensorTipo, lectura));
        }

        // Mostrar los datos generados
        Console.WriteLine("Datos generados de los sensores (sin agrupar):");
        foreach (var s in sensores)
        {
            Console.WriteLine($"Sensor: {s.Sensor}, Lectura: {s.Lectura}");
        }

        // AQUÍ COMPLETAR EL CÓDIGO
    }
}
