/* 
 * Este programa muestra el cálculo del área de un rectángulo
 * utilizando clases y objetos
 */
#include <iostream>
#include <stdlib.h>

// Utilizar la clase estándar std
using namespace std;

/* Generar la clase Rectángulo */
class Rectangulo
{
// Atributos/Métodos privados (solo accesibles dentro de la clase)
private:
    float longitud;
    float ancho;
// Atributos/Métodos públicos (accesibles desde cualquier otra clase)
public:
    Rectangulo();
    ~Rectangulo();
    float calcularArea(float l , float a);
    void mostrarDatos(float r,float l,float a);
};

Rectangulo::Rectangulo() // Método especial Rectangulo
{
	// Los atributos pueden iniciarse aquí
	longitud = 0;
	ancho = 0;
	cout<<"Inicia programa y atributos"<<endl;
}

Rectangulo::~Rectangulo()
{
	cout<<"Fin de programa y de objeto"<<endl;
}

float Rectangulo::calcularArea(float l, float a)
{
    return l*a;
}

void Rectangulo::mostrarDatos(float r, float l, float a)
{
    cout<<"El lado es  = "<<l<<endl;
    cout<<"El ancho es = "<<a<<endl;
    cout<<"El area es = "<<r<<endl;
}

int main(void)
{
	// Variables locales
    float res,longitud,ancho;
	// Instancia del método (Se manda a llamar el constructor por defecto)
    Rectangulo Obj;
	
    cout<<"PROGRAMA QUE CALCULA EL AREA DE UN RECTANGULO"<<endl;
    cout<<"Teclee el lado"<<endl;
    cin>>longitud;		// Es imposible acceder desde aquí a Obj.longitud
    cout<<"Teclee el ancho"<<endl;
    cin>>ancho;			// Es imposible acceder desde aquí a Obj.ancho
    res = Obj.calcularArea(longitud,ancho);
    cout<<"A continuacion se mostraran los datos"<<endl;
    Obj.mostrarDatos(res,longitud,ancho);
    
	return 0;
	// Al finalizar el programa se manda a llamar de manera automática el destructor
}