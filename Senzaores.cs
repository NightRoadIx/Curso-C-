using System;
using System.Collections.Generic;
using System.Linq;

// Programación orientada a objetos (POO)
// 1. Abstracción
public class Sensor
{
    // ATRIBUTOS
    // Como describimos el objeto (variables)
    private string _tipo;
    private double _lectura;

    // 2. Encapsulación
    // Atributos, SOLAMENTE se pueden modificar dentro de la
    // clase, por segurida' para evitar que se cambien valores
    public string Tipo
    {
        // Lectura, es abierto
        get => _tipo;
        // Escritura
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La cadena no debe estar vacía");
            _tipo = value;
        }
    }

    public double Lectura
    {
        // Lectura, es abierto
        get => _lectura;
        // Escritura
        private set
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "El valor no puede ser menor a cero");
                _lectura = value;
        }
    }

    // Para usar la fecha y hora actuales
    public DateTime Tiempo {get; private set; }


    // MÉTODOS
    // Qué es lo que hace el objeto (funciones)

    // Constructor
    // Método especial que asigna espacio en memoria 
    public Sensor(string tipo, double lecturaInicial)
    {
        Tipo = tipo;
        Actualizar(lecturaInicial);
    }

    public void Actualizar(double nuevaLectura)
    {
        // Funado !!!!! =D
        // Validación específica según el tipo de sensor
        if (Tipo == "Motor" && (nuevaLectura < 0 || nuevaLectura > 9000))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "RPM fuera de rango");
        
        if (Tipo == "Temperatura" && (nuevaLectura < -40 || nuevaLectura > 150))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Temperatura fuera de rango");

        if (Tipo == "Velocidad" && (nuevaLectura < 0 || nuevaLectura > 260))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Velocidad fuera de rango");            

        if (Tipo == "Oxigenación" && (nuevaLectura < 0 || nuevaLectura > 100))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Oxigenación fuera de rango"); 

        // Pasar por la propiedad
        Lectura = nuevaLectura;
        // Lectura de la fecha y hora actuales
        Tiempo = DateTime.Now;
    }

    // Determina estado crítico
    public bool EsCritico()
    {
        return Tipo switch
        {
            "Motor" => Lectura > 6500,
            "Temperatura" => Lectura > 95,
            "Velocidad" => Lectura > 180,
            "Oxigenación" => Lectura < 92,
            _ => false
        };
    }    

    // Representación del sensor
    // Sobrecarga de la función ToString() que todo objeto
    // posee en la POO
    public override string ToString()
    {
        var estado = EsCritico() ? "CRÍTICO" : "OK";
        return $"{Tiempo:HH:mm:ss} | {Tipo,-12} | {Lectura,8:F2} | {estado}";
    }

}

class Progran
{
    static void Main()
    {
        Sensor s1 = new Sensor("Motor", 3200);
        Sensor s2 = new Sensor("Temperatura", 88);

        Console.WriteLine(s1);
        Console.WriteLine(s2);

        s1.Actualizar(7000);
        s2.Actualizar(100);

        Console.WriteLine("\nDespués de actualizar:\n");

        Console.WriteLine(s1);
        Console.WriteLine(s2);

    }
}
