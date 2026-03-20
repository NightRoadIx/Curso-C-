using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

// Programación orientada a objetos (POO)
// 1. Abstracción
/*
public class Sensor
{
    // ATRIBUTOS
    // Como describimos el objeto
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

    // 3. Sobrecarga de funciones, polimorfismo
    // Representación del sensor
    // Sobrecarga de la función ToString() que todo objeto
    // posee en la POO
    public override string ToString()
    {
        var estado = EsCritico() ? "CRÍTICO" : "OK";
        return $"{Tiempo:HH:mm:ss} | {Tipo,-12} | {Lectura,8:F2} | {estado}";
    }

}
*/

// 3. Herencia 
// Para reusar las cositas de las clases
// y hacer las clases más mejores
public abstract class Sensor
{
    public string Tipo {get; }
    public double Lectura {get; protected set; }
    public DateTime Timestamp {get; protected set; }

    // Construptor
    public Sensor(string tipo, double lecturaInicial)
    {
        if(string.IsNullOrWhiteSpace(tipo))
            throw new ArgumentException("Tipo inválido");
        
        Tipo = tipo;
        Actualizar(lecturaInicial);
    }

    public void Actualizar(double nuevaLectura)
    {
        Validar(nuevaLectura);
        Lectura = nuevaLectura;
        Timestamp = DateTime.Now;
    }

    // protected, método que solamente funciona en herencia
    // abstract, tipo abstracto, indica que las clases hijas
    // DEBEN implementar este método a h...o
    protected abstract void Validar(double value);
    public abstract bool EsCritico();

    public override string ToString()
    {
        string estado = EsCritico() ? "Crítico" : "OK";
        return $"{Tipo} | {Lectura:F2} | {Timestamp:HH:mm:ss} | {estado}";
    }
}

/* CLASES HIJAS */
//Aquí se van colocando las clases hijas, que heredan de la clase padre Sensor
// la herencia se coloca con :
public class SensorMotor : Sensor
{
    // Aquí se declara el constructor de clase que hereda de la clase "base"
    // el constructor (o sea Sensor)
    public SensorMotor(double lecturaInicial) : base("Motor", lecturaInicial)
    {
    }

    // El método Validar estaba como abstracto y en la clase hija cuando se
    // declara se debe sobrecargar (override) para indicar que aquí se va a definir
    // un comportamiento especial de este método para esta clase hija
    // 4. Sobrecarga de funciones o polimorfismo
    protected override void Validar(double value)
    {
        if (value < 0 || value > 9000)
            throw new ArgumentOutOfRangeException(nameof(value), "RPM fuera de rango.");
    }

    // Mismo proceso para el método EsCritico()
    public override bool EsCritico()
    {
        return Lectura > 6500;
    }

    // Todos los demás métodos se heredan y se mantiene su comportamiento como en la clase padre
}

public class SensorTemperatura : Sensor
{
    public SensorTemperatura(double lecturaInicial) : base("Temperatura", lecturaInicial)
    {
    }

    protected override void Validar(double value)
    {
        if (value < -40 || value > 150)
            throw new ArgumentOutOfRangeException(nameof(value), "Temperatura fuera de rango.");
    }

    public override bool EsCritico()
    {
        return Lectura > 95;
    }
}



class Progran
{
    static void Main()
    {
        // Se observa que se puede instanciar el objeto como Sensor (clase padre)
        // Usando el comportamiento de cada clase hija con su respectivo constructor
        Sensor s1 = new SensorMotor(3200);
        Sensor s2 = new SensorTemperatura(88);

        Console.WriteLine(s1);
        Console.WriteLine(s2);

        s1.Actualizar(7000);
        s2.Actualizar(100);

        Console.WriteLine("\nDespués de actualizar:\n");

        Console.WriteLine(s1);
        Console.WriteLine(s2);


        Int32 laGrande = new Int32();
        laGrande.ToString();

        // Crear una lista de sensores
        List<Sensor> sensores = new List<Sensor>
        {
            new SensorMotor(7000),
            new SensorTemperatura(100),
        } ;

        // Se recorre para ver si los sensores en lista
        // son críticos, aquí se puede ver el uso de
        // polimorfismo, dado que se trata de una función
        // con el mismo nombre, pero con cada objeto
        // de diferente tipo tiene un comportamiento diferente
        // una especie de "if"
        foreach(var sensor in sensores)
            Console.WriteLine(sensor.EsCritico());

    }
}
