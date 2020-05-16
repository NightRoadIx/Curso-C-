using System;
/* Namespace para el manejo de cuestiones de criptografía (cifrado y descifrado) */
/* Revisar documentación adicional: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography?view=netcore-3.1 */
using System.Security.Cryptography;
/* Namespace para el manejo de atribtuos de texto */
using System.Text;

namespace Cifratogrfa
{
	class Secreto
	{
		/* ATRIBUTOS */
		// Aquí se coloca la cadena de texto que es la llave de cifrado
		// Puede tratarse de cualquier combinación de caracteres (entre más larga es más seguro, pero el algoritmo es más lento)
		private string clave = "cualquiercombinacion";
		
		/* METODOS */
		// Método para cifrado
		public string cifrar(string cadena)
		{
			// Para guardar la llave para el cifrado 3DES
			byte[] llave;
			// Arreglo donde se guardará la cadena descifrada
			byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena);
			
			// Cifrado utilizando el algoritmo MD5, crear un objeto MD5CryptoServiceProvider
			/* 
			 * MD5 (Message-Digest Algortihm 5) es un algoritmo de reducción criptográfico de 128 bits
			 * el cual es muy utilizado, sobre todo para comprobar que un archivo no haya sido modificado, esto es de mucha
			 * utilidad cuando se descargan archivos y con ello saber si este no fue corrompido tras la transferencia.
			 * La codificación obtenida es un número de 32 símbolos hexadecimales (1 símbolo hexadecimal = 4 bits = 1 nibble)
			 * por lo que se trata de una rerpezsentación de 128 bits (4 bits x 32 = 128)
			 * */
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			// Con el objeto creado, calcular el valor de la función Hash
			/*
			 * Una función hasj o función digest es una función que mediante un algoritmo que permite convertir
			 * un conjunto de elementos (en general cadenas de texto de cualquier longitud) a un rango de salida finito
			 * el cual normalmente es una cadena de texto de longitud fija (8, 16, 32 caracteres).
			 * La idea básica es que la función hash sirva como una representación compacta de la cadena de entrada
			 * */
			// Codificar la clave a UTF-8
			llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
			// Liberar todos los recursos utilizados por el algoritmo hash
			md5.Clear();
			// Se cifra utilizando el algoritmo 3DES
			/* El algoritmo de cifrado 3DES fue desarrollado tras  observar que el algoritmo DES fue roto en 
			 * menos de 24 horas, por lo que se duplico la longitud efectiva de la clave (56 bit) a 112 bits,
			 * pero triplicando el costo computacional al triplicar el número de operaciones de cifrado.
			 * Se cifra por bloques de 64 bits
			 * */
			TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
			// Configurar
			tripledes.Key = llave;
			tripledes.Mode = CipherMode.ECB;
			tripledes.Padding = PaddingMode.PKCS7;
			// Se inicia la conversión de la cadena creando el encriptador
			ICryptoTransform convertir = tripledes.CreateEncryptor();
			// Arreglo de bytes donde se guardará la cadena cifrada
			byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
			tripledes.Clear();
			
			// Se convierte la cadena a string de 64 bits y se regresa
			return Convert.ToBase64String(resultado, 0, resultado.Length);
		}
		
		// Método para descifrado
        public string descifrar(string cadena) 
        {
        	// Para guardar la llave para el cifrado 3DES
            byte[] llave;
            // Arreglo donde guardaremos la cadena descifrada
            byte[] arreglo = Convert.FromBase64String(cadena);
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            // Se calcula el hash
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            // Se inicia la conversión de la cadena creando el desencriptador
            ICryptoTransform convertir = tripledes.CreateDecryptor();
            // Obtener el resultado 
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();
            // Se obtiene la cadena
            string cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado);
            
            // Regresar la cadena descifrada
            return cadena_descifrada;
        }	
	}
	
	class Program
	{		
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			// Crear el objeto que permita manejar la clase Secreto
			Secreto sec = new Secreto();
			string cad, cad1;
			
			Console.Write("Ingresar una cadena de texto para su cifrado: ");
			cad = Console.ReadLine();
			
			Console.WriteLine("\nCadena a cifrar  : " + cad);
			cad1 = sec.cifrar(cad);
			Console.WriteLine("Cadena cifrada   : " + cad1 + " (longitud: " + cad1.Length.ToString() + ")");
			Console.WriteLine("Cadena descifrada: " + sec.descifrar(cad1));
			
			Console.ReadKey(true);
		}
	}
}