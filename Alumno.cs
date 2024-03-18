/*
Programación Orientada a Objetos (POO):
La POO es un paradigma de programación que se basa en cuatro pilares fundamentales:

Abstracción: Permite simplificar la realidad modelando solo los aspectos 
esenciales de un objeto del mundo real. 

Encapsulamiento: Consiste en ocultar los detalles internos de implementación de 
un objeto y exponer solo lo que es necesario. 

Herencia: Permite que una clase herede propiedades y comportamientos de otra. 

Polimorfismo: Permite que objetos de diferentes tipos respondan a un mismo mensaje o 
función. 

*/
using System;

/// <summary>
/// Clase que representa a una persona con nombre, apellido paterno, apellido materno y edad.
/// </summary>
public class Persona
{
    /* 
     * Lo siguiente se conoce como getters y setters
     * ya que, dada la característica de encapsulación 
     * de la POO, los atributos no pueden ser leídos
     * ni modificados fuera de la clase, entonces, hay que
     * generar métodos que ingresen de manera indirecta
     * getter - obtiene la información del atributi
     * setter - coloca la información al atributo
     */
    /// <summary>
    /// Nombre de la persona.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Apellido paterno de la persona.
    /// </summary>
    public string ApPaterno { get; set; }

    /// <summary>
    /// Apellido materno de la persona.
    /// </summary>
    public string ApMaterno { get; set; }

    /// <summary>
    /// Edad de la persona.
    /// </summary>
    public int Edad { get; set; }

    /// <summary>
    /// Constructor de la clase Persona.
    /// </summary>
    /// <param name="nombre">Nombre de la persona.</param>
    /// <param name="apPaterno">Apellido paterno de la persona.</param>
    /// <param name="apMaterno">Apellido materno de la persona.</param>
    /// <param name="edad">Edad de la persona.</param>
    public Persona(string nombre, string apPaterno, string apMaterno, int edad)
    {
        Nombre = nombre;
        ApPaterno = apPaterno;
        ApMaterno = apMaterno;
        Edad = edad;
    }
}

/// <summary>
/// Clase que representa a un alumno, hereda de la clase Persona.
/// </summary>
public class Alumno : Persona
{
    /// <summary>
    /// Número de boleta del alumno.
    /// </summary>
    public string NumBoleta { get; set; }

    /// <summary>
    /// Correo electrónico del alumno.
    /// </summary>
    public string CorreoElectronico { get; set; }

    /// <summary>
    /// Constructor de la clase Alumno.
    /// </summary>
    /// <param name="nombre">Nombre del alumno.</param>
    /// <param name="apPaterno">Apellido paterno del alumno.</param>
    /// <param name="apMaterno">Apellido materno del alumno.</param>
    /// <param name="edad">Edad del alumno.</param>
    /// <param name="numBoleta">Número de boleta del alumno.</param>
    /// <param name="correoElectronico">Correo electrónico del alumno.</param>
    public Alumno(string nombre, string apPaterno, string apMaterno, int edad, string numBoleta, string correoElectronico)
        : base(nombre, apPaterno, apMaterno, edad)
    {
        NumBoleta = numBoleta;
        CorreoElectronico = correoElectronico;
    }

    /// <summary>
    /// Imprime el nombre completo del alumno en la consola.
    /// </summary>
    public void DarNombreCompleto()
    {
        Console.WriteLine("Mi nombre es: " + Nombre + " " + ApPaterno + " " + ApMaterno);
    }
}

/// <summary>
/// Clase principal que contiene la función Main como punto de entrada del programa.
/// </summary>
public class Program
{
    /// <summary>
    /// Función principal del programa.
    /// </summary>
    public static void Main()
    {
        // Crear un objeto de tipo Alumno
        Alumno alumno = new Alumno("Juan", "Pérez", "García", 20, "2021680001", "juan.perez@example.com");

        // Imprimir el nombre completo del alumno
        alumno.DarNombreCompleto();

        // Imprimir el número de boleta y correo electrónico del alumno
        Console.WriteLine("Número de boleta: " + alumno.NumBoleta);
        Console.WriteLine("Correo electrónico: " + alumno.CorreoElectronico);
    }
}
