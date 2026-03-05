using System;

public class Sensor
{
    // Campos privados (estado interno)
    private string _tipo;
    private double _lectura;

    // Propiedad pública de solo lectura externa
    public string Tipo
    {
        get => _tipo;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tipo no puede estar vacío.");

            _tipo = value;
        }
    }

    // Propiedad pública controlada
    public double Lectura
    {
        get => _lectura;
        private set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Lectura no puede ser negativa.");

            _lectura = value;
        }
    }

    // Para trabajar con la hora y fecha actuales
    public DateTime Timestamp { get; private set; }

    // Constructor
    public Sensor(string tipo, double lecturaInicial)
    {
        Tipo = tipo;
        Actualizar(lecturaInicial);
    }

    // Método que simula actualización desde ECU
    public void Actualizar(double nuevaLectura)
    {
        // Validación específica según tipo de sensor
        if (Tipo == "Motor" && (nuevaLectura < 0 || nuevaLectura > 9000))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "RPM fuera de rango.");

        if (Tipo == "Temperatura" && (nuevaLectura < -40 || nuevaLectura > 150))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Temperatura fuera de rango.");

        if (Tipo == "Velocidad" && (nuevaLectura < 0 || nuevaLectura > 260))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Velocidad fuera de rango.");

        if (Tipo == "Oxigenación" && (nuevaLectura < 0 || nuevaLectura > 100))
            throw new ArgumentOutOfRangeException(nameof(nuevaLectura), "Oxigenación fuera de rango.");

        Lectura = nuevaLectura; // pasa por la propiedad (encapsulamiento)
        Timestamp = DateTime.Now;
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
    public override string ToString()
    {
        var estado = EsCritico() ? "CRÍTICO" : "OK";

        return $"{Timestamp:HH:mm:ss} | {Tipo,-12} | {Lectura,8:F2} | {estado}";
    }
}
