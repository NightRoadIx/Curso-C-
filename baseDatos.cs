using System;
// Librería para el manejo de BD de SQLite
using Microsoft.Data.Sqlite;
// Librería para iniciar el soporte de SQLite en algunas plataformas
using SQLitePCL;

namespace Erencia
{
    class Programe
    {
        public static void Main(string[] args)
        {
            // Con esto se inicia los componentes internos de SQLite
            /*
             En algunas plataformas, como MAUI, SQLite no viene preconfigurado
             por lo que se requiere iniciar los procesos que requiere
             SQLite
             */
            Batteries.Init();

            // Ruta del archivo que contendrá a la BD
            string conexion = "Data Source=miBD.db";
            // Usar una manejador de contexto
            // para tener acceso al archivo
            using (var connection = new SqliteConnection(conexion))
            {
                // Se la abren a la BD
                connection.Open();
                // Crear una tabla
                var tablaCmd = connection.CreateCommand();
                tablaCmd.CommandText =
                    @"
                    CREATE TABLE IF NOT EXISTS Alumnos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT,
                    Carrera TEXT,
                    Edad INTEGER
                        );
                    ";
                // Ejecutar la consulta
                tablaCmd.ExecuteNonQuery();

                Console.WriteLine("La tabla se ha creado correctamente.");

                // SQL CRUD
                // Escribir datos en la tabla (CREATE)
                /* var insertCmd = connection.CreateCommand();
                 insertCmd.CommandText = @"
                     INSERT INTO Alumnos (Nombre, Carrera, Edad)
                     VALUES ('Wendy', 'Reich Auschwitz', 666)
                      ";
                 insertCmd.ExecuteNonQuery();*/

                // Actualizar las BD (UPDATE)
                /*var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = "UPDATE Alumnos SET Edad = 616 WHERE Nombre = 'Wendy'";
                updateCmd.ExecuteNonQuery();*/

                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Alumnos WHERE Nombre = 'Alexis'";
                deleteCmd.ExecuteNonQuery();

                // Leer los datos de la tabla (READ)
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id, Nombre, Carrera, Edad FROM Alumnos";

                using (var reader = selectCmd.ExecuteReader())
                {
                    Console.WriteLine("Datos: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt32(0)} \t {reader.GetString(1)} \t {reader.GetString(2)} \t {reader.GetInt32(3)}");
                    }
                }
            }
        }
    }
}
