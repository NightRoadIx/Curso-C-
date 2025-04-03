using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

/// <summary>
/// Programa principal para demostrar operaciones CRUD con SQLite
/// </summary>
class Program
{
    /// <summary>
    /// Punto de entrada principal de la aplicación
    /// </summary>
    static void Main()
    {
        try
        {
            Console.WriteLine("Iniciando aplicación de CRUD con SQLite...");

            // Cadena de conexión para la base de datos SQLite
            string connectionString = "Data Source=miBD.db";

            // Asegurar que las tablas existen con la estructura correcta
            CrearTablas(connectionString);

            // Insertar datos de ejemplo en la tabla Alumnos
            InsertarDatos(connectionString, "Alumnos",
                new List<string> { "Nombre", "Carrera", "Edad" },
                new List<object> { "Carlos", "Sistemas Automotrices", 23 });

            InsertarDatos(connectionString, "Alumnos",
                new List<string> { "Nombre", "Carrera", "Edad" },
                new List<object> { "Ana", "Mecatrónica", 21 });

            // Insertar datos de ejemplo en la tabla Materias
            // Nota: Requiere que exista un profesor con Id=3
            InsertarDatos(connectionString, "Materias",
                new List<string> { "Nombre", "HorasSemana", "IdProfesor" },
                new List<object> { "Electrónica Automotriz", 40, 3 });

            // Consultar y mostrar los datos de las tablas
            ConsultarDatos(connectionString, "Alumnos");
            ConsultarDatos(connectionString, "Materias");

            Console.WriteLine("Operaciones completadas con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Detalles: {ex}");
        }
    }

    /// <summary>
    /// Crea las tablas necesarias en la base de datos si no existen
    /// </summary>
    /// <param name="connectionString">Cadena de conexión a la base de datos</param>
    /// <remarks>
    /// Estructura creada:
    /// - Tabla Alumnos (datos básicos de estudiantes)
    /// - Tabla Profesores (datos de instructores)
    /// - Tabla Materias (asignaturas con relación a profesores)
    /// - Tabla AlumnosMaterias (relación muchos-a-muchos entre alumnos y materias)
    /// </remarks>
    static void CrearTablas(string connectionString)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Habilitar soporte para claves foráneas en SQLite (requerido para integridad referencial)
            var pragmaCommand = connection.CreateCommand();
            pragmaCommand.CommandText = "PRAGMA foreign_keys = ON;";
            pragmaCommand.ExecuteNonQuery();

            var command = connection.CreateCommand();
            command.CommandText = @"
                -- Tabla de alumnos
                CREATE TABLE IF NOT EXISTS Alumnos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Carrera TEXT,
                    Edad INTEGER
                );
                
                -- Tabla de profesores
                CREATE TABLE IF NOT EXISTS Profesores (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL
                );

                -- Tabla de materias con relación a profesores
                CREATE TABLE IF NOT EXISTS Materias (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    HorasSemana REAL NOT NULL,
                    IdProfesor INTEGER NOT NULL,
                    FOREIGN KEY (IdProfesor) REFERENCES Profesores(Id) ON DELETE SET NULL
                );

                -- Tabla de relación muchos-a-muchos entre alumnos y materias
                CREATE TABLE IF NOT EXISTS AlumnosMaterias (
                    Id INTEGER NOT NULL UNIQUE,
                    IdAlumnos INTEGER NOT NULL,
                    IdMaterias INTEGER NOT NULL,
                    PRIMARY KEY(Id AUTOINCREMENT),
                    FOREIGN KEY(IdAlumnos) REFERENCES Alumnos(Id) ON DELETE CASCADE,
                    FOREIGN KEY(IdMaterias) REFERENCES Materias(Id) ON DELETE CASCADE
                );";

            command.ExecuteNonQuery();
            Console.WriteLine("Tablas creadas/verificadas correctamente.");
        }
    }

    /// <summary>
    /// Inserta datos en una tabla especificada
    /// </summary>
    /// <param name="connectionString">Cadena de conexión a la base de datos</param>
    /// <param name="tabla">Nombre de la tabla destino</param>
    /// <param name="columnas">Lista de nombres de columnas</param>
    /// <param name="valores">Lista de valores correspondientes a las columnas</param>
    /// <exception cref="ArgumentException">Se lanza cuando el número de columnas y valores no coincide</exception>
    /// <remarks>
    /// Ejemplo de uso:
    /// InsertarDatos(connString, "Alumnos", ["Nombre", "Edad"], ["Juan", 25])
    /// </remarks>
    static void InsertarDatos(string connectionString, string tabla,
        List<string> columnas, List<object> valores)
    {
        // Validación de parámetros
        if (columnas.Count != valores.Count)
            throw new ArgumentException("El número de columnas y valores debe ser el mismo.");

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Construcción dinámica de la consulta SQL
            string columnasStr = string.Join(", ", columnas);
            string parametrosStr = string.Join(", ", columnas.ConvertAll(c => $"@{c}"));

            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO {tabla} ({columnasStr}) VALUES ({parametrosStr})";

            // Asignación de parámetros
            for (int i = 0; i < columnas.Count; i++)
            {
                // Manejo de valores nulos (convierte null a DBNull.Value)
                command.Parameters.AddWithValue($"@{columnas[i]}", valores[i] ?? DBNull.Value);
            }

            // Ejecución del comando
            int filasAfectadas = command.ExecuteNonQuery();
            Console.WriteLine($"Insertadas {filasAfectadas} filas en {tabla}.");
        }
    }

    /// <summary>
    /// Consulta y muestra todos los datos de una tabla
    /// </summary>
    /// <param name="connectionString">Cadena de conexión a la base de datos</param>
    /// <param name="tabla">Nombre de la tabla a consultar</param>
    /// <remarks>
    /// Muestra los resultados formateados en la consola con:
    /// - Encabezados de columnas
    /// - Separadores visuales
    /// - Datos alineados
    /// </remarks>
    static void ConsultarDatos(string connectionString, string tabla)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {tabla}";

            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine($"\nContenido de la tabla {tabla}:");
                Console.WriteLine(new string('-', 50));

                // Mostrar nombres de columnas
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader.GetName(i),-20}");
                }
                Console.WriteLine("\n" + new string('-', 50));

                // Mostrar filas de datos
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader[i],-20}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
