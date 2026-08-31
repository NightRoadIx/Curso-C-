Console.WriteLine("Farmeando Aura");

// Como en lenguaje C
// Estos son comentarios de una línea

/*
    Y comentarios de varias líneas
*/

/*
    Tipos de variables
    Son los tipos de datos que se pueden almacenar en memoria
    Se anexa el tamaño en bits de cada tipo de variable
*/
// Valor booleano, solo toma dos valores, true o false (1 bit)
bool miBoleano = true;
// Valor tipo byte (8 bits)
byte miMordida = 255;
// Variable caracter (16 bits)
// Esta se modificó de 8 a 16 bits al pasar de código ASCII a Unicode
char caracter = 'c';
// Variable corta (16 bits)
short miCorta = 15;
// Variable entero (32 bits)
int miNum = 15;
// Variable entero (64 bits)
long otroNum = 15642;
// Variable flotante (32 bits), se requiere colocar una 'f' al final del número
float numDecimal = 3.1416f;
// Variable doble (64 bits)
double otroDecimal = 3.1415926534;
// Vairable decimal (128 bits), se requiere colocar una 'm' al final del número
decimal numDecimalGrande = 3.141592653589793238462643383279502m;
// Variable cadena de caracteres (Dependiendo de la cantidad de caracteres)
string nombre = "Juan Nepomuceno";

// Las variables se pueden mostrar en consola con el método WriteLine
Console.WriteLine(miBoleano);
// Haciendo "concatenación" de variables con texto para mostar tanto texto como variables
Console.WriteLine("El valor de miNum es: " + miNum);
// Sin embargo, es posible usar otra notación para mostrar variables en consola, usando el método WriteLine con llaves y el símbolo $ al inicio de la cadena de texto
Console.WriteLine($"Los valores: {numDecimal}, {otroDecimal} y {numDecimalGrande} son decimales de diferente tamaño");

/*
    Función para ingresar datos
    Console.ReadLine()
*/
Console.WriteLine("Ingrese su nombre: ");
// C# permite declarar variables a lo largo del código, sin embargo no es aconsejable
string nombreUsuario = Console.ReadLine();
Console.WriteLine("Nombre: " + nombreUsuario);
Console.WriteLine("Ingrese su edad: ");
/* 
    Sin embargo, lo que regresa esta función es una cadena de texto (string)
    Por lo que es necesario usar un método para convertir
    Convert.ToBoolean() 
    Convert.ToDouble() 
    Convert.ToString() 
    Convert.ToInt32()
    Convert.ToInt64()
*/
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Edad: " + edad);
Console.Write("Press any key to continue . . . "); // printf();
