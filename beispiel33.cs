using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace databasizacion
{
    class Estudiante
    {
        // Atributos
        public int RollNo { get; set; }
        public string Nombre { get; set; }
        public float Calificacion { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFirebaseConfig ifc = new FirebaseConfig()
            {
                AuthSecret = "1HQd7t7T8G5joitCGQ1qW0Jui3piFOGlvY0aG01o",
                BasePath = "https://adam-ddc87.firebaseio.com/"
            };

            IFirebaseClient client;

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                Console.WriteLine("Conexación se realizo de manera exitosa");

                /* CRUD */
                // Create o insertar
                Estudiante estu = new Estudiante();

                estu.RollNo = 2;
                estu.Nombre = "Pepito Pechugas";
                estu.Calificacion = 5.89f;

                client.Set(@"Estudiantes/" + estu.RollNo, estu);
                Console.WriteLine("Los datos se guardaron de manera correcta");

                Console.WriteLine("Continuar");
                Console.ReadKey();

                // Read, lectura o búsqueda
                Console.Write("Ingresar dato a buscar: ");
                int busca = Convert.ToInt32(Console.ReadLine());

                // La búsqueda sobre la base de datos
                var respuesta = client.Get(@"Estudiantes/" + busca);
                Estudiante dstu = respuesta.ResultAs<Estudiante>();

                // Verificar si el objeto es no nulo
                if (dstu != null)
                {
                    Console.WriteLine("Registro hallado:");
                    Console.WriteLine("{0} tiene {1}", dstu.Nombre, dstu.Calificacion);
                }
                else
                    Console.WriteLine("No se hallo el registro");

                Console.WriteLine("Continuar");
                Console.ReadKey();

                // Update, actualización
                estu.Calificacion = 8.86f;
                estu.RollNo = 2;
                client.Update(@"Estudiantes/" + estu.RollNo, estu);

                Console.WriteLine("Continuar");
                Console.ReadKey();
                // Delete, borrar
                client.Delete(@"Estudiantes/" + "1");

            }
            catch
            {
                Console.WriteLine("Error en obtener base de datos de la web");
            }
            finally
            {
                Console.WriteLine("Presione una tecla pa' salir");
                Console.ReadKey();
            }
        }
    }
}
