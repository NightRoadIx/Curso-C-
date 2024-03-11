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
/// Representa a un estudiante con atributos como nombre, número de boleta, edad, etc.
/// </summary>
public class Alumno 
{
    // ATRIBUTOS
    private string nombre;
    private string appPaterno;
    private string appMaterno;
    private string numBoleta;
    private int edad;
    private string correoElectronico;

    // MÉTODOS

    /// <summary>
    /// Constructor por defecto. Inicializa los atributos con valores predeterminados.
    /// </summary>
    public Alumno()
    {
        this.nombre = "";
        this.appPaterno = "";
        this.appMaterno = "";
        this.numBoleta = "";
        this.edad = 18;
        this.correoElectronico = "usuario@correo.com";
    }
    
    /// <summary>
    /// Constructor que permite inicializar los atributos con valores específicos.
    /// </summary>
    /// <param name="namen">Nombre del alumno.</param>
    /// <param name="pat">Apellido paterno del alumno.</param>
    /// <param name="mat">Apellido materno del alumno.</param>
    /// <param name="bol">Número de boleta del alumno.</param>
    /// <param name="ega">Edad del alumno.</param>
    /// <param name="mail">Correo electrónico del alumno.</param>
    public Alumno(string namen, string pat, string mat, string bol, int ega, string mail)
    {
        this.nombre = namen;
        this.appPaterno = mat;
        this.appMaterno = pat;
        this.numBoleta = bol;
        this.edad = ega;
        this.correoElectronico = mail;
    }
    
    /// <summary>
    /// Imprime el nombre completo del alumno en la consola.
    /// </summary>
    public void DarNombreCompleto()
    {
        Console.WriteLine("Mi nombre es: " + this.nombre + " " + this.appPaterno + " " + this.appMaterno);
    }
} 

/// <summary>
/// Clase principal que contiene la función Main como punto de entrada del programa.
/// </summary>
public class Program
{
    // Función principal
    public static void Main()
    {
        // Instanciar un objeto a partir de una clase
        Alumno gus = new Alumno();
        gus.DarNombreCompleto();
        
        Alumno alo = new Alumno("Antonie", "Gignac", "Ratatouille", "2015680185", 26, "meEncantaElPiton@gmail.com");
        alo.DarNombreCompleto();

        // FIXME: Los atributos son de tipo "private" por tanto no se puede tener acceso fuera de la clase
        // Esto genera un error de compilación, ya que los atributos son privados y no accesibles desde fuera de la clase.
        gus.Nombre = "El gus";
        gus.AppPaterno = "Vilchis";
        gus.AppMaterno = "Bustos";

        gus.DarNombreCompleto();
    }
}
