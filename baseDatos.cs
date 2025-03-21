using System;
// SQL librería
using Microsoft.Data.Sqlite;

namespace Erencia
{
    class Programe
    {
        public static async void Main(string[] args)
        {
            // Ruta del archivo que contendrá a la BD
            string conexion = "Data Source=miBD.db";
            // Usar una manejador de contexto
            // para tener acceso al archivo
            using (var connection = new SqliteConnection(conexion))
            {
                try
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
                    //tablaCmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
