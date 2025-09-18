using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latex02
{
    /// <summary>
    /// Clase base que representa un sensor genérico de un vehículo.
    /// Incluye propiedades comunes a cualquier sensor como tipo, unidad y valor.
    /// </summary>
    class SensorVehicular
    {
        /// <summary>
        /// Tipo de sensor (ejemplo: temperatura, velocidad, presión).
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Unidad de medida utilizada por el sensor (ejemplo: °C, km/h, PSI).
        /// </summary>
        public string Unidad { get; set; }

        /// <summary>
        /// Valor actual leído por el sensor.
        /// </summary>
        public double Valor { get; set; }

        /// <summary>
        /// Método virtual que muestra la información básica del sensor.
        /// Puede ser sobrescrito por las clases hijas para especializar el comportamiento.
        /// </summary>
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"{Tipo}: {Valor} {Unidad}");
        }
    }

    /// <summary>
    /// Clase derivada que representa un sensor de temperatura.
    /// Hereda de SensorVehicular y agrega un umbral máximo de seguridad.
    /// </summary>
    class SensorTemperatura : SensorVehicular
    {
        /// <summary>
        /// Valor máximo permitido para la temperatura antes de considerarse crítico.
        /// </summary>
        public double UmbralMaximo { get; set; }

        /// <summary>
        /// Método sobrescrito que muestra la información de temperatura junto con su umbral máximo.
        /// </summary>
        public override void MostrarInfo()
        {
            Console.WriteLine($"{Tipo}: {Valor}{Unidad} (Umbral Máx: {UmbralMaximo}{Unidad})");
        }
    }

    /// <summary>
    /// Clase derivada que representa un sensor de velocidad.
    /// Hereda de SensorVehicular y agrega un límite de velocidad máxima.
    /// </summary>
    class SensorVelocidad : SensorVehicular
    {
        /// <summary>
        /// Velocidad máxima permitida para el vehículo.
        /// </summary>
        public double VelocidadMaxima { get; set; }

        /// <summary>
        /// Método sobrescrito que muestra la información de velocidad junto con el límite máximo.
        /// </summary>
        public override void MostrarInfo()
        {
            Console.WriteLine($"{Tipo}: {Valor}{Unidad} (Velocidad Máx: {VelocidadMaxima}{Unidad})");
        }
    }

    internal class Program
    {
        /// <summary>
        /// Método principal del programa.
        /// Aquí se crean los sensores, se agregan a una lista y se muestran sus valores.
        /// </summary>
        static void Main(string[] args)
        {
            // Crear una lista de sensores.
            // Nota: la lista se declara como tipo SensorVehicular,
            // lo que permite almacenar objetos de las clases hijas (Temperatura, Velocidad).
            List<SensorVehicular> sensores = new List<SensorVehicular>();

            // Instanciar y agregar un sensor de temperatura a la lista.
            // El objeto se inicializa con valores específicos para cada propiedad.
            sensores.Add(new SensorTemperatura
            {
                Tipo = "Temperatura del motor",
                Unidad = "°C",
                Valor = 90,
                UmbralMaximo = 120
            });

            // Instanciar y agregar un sensor de velocidad a la lista.
            sensores.Add(new SensorVelocidad
            {
                Tipo = "Velocidad del vehículo",
                Unidad = "km/h",
                Valor = 80,
                VelocidadMaxima = 220
            });

            // Recorrer la lista y mostrar la información de cada sensor.
            // Aquí ocurre el polimorfismo: aunque la lista es de tipo SensorVehicular,
            // se ejecuta el método sobrescrito de la clase hija correspondiente.
            foreach (SensorVehicular s in sensores)
            {
                s.MostrarInfo();
            }
        }
    }
}
