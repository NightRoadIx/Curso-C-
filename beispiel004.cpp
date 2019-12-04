#include <stdio.h>

#include <iostream>

using namespace std;

/* ClaseA */
class ClaseA
{
// Atributos protegidos
protected:
	int datoA;
// Atributos/Métodos públicos
public:
	// Constructor
	ClaseA() { datoA = 10; /*cout<<"ClaseA inicia a: "<<datoA<<endl;*/ }
	// Destructor
	~ClaseA() { cout<<"Fin de ClaseA"<<endl; }
	int LeerA() { return datoA; }
};

/* ClaseB
 * Esta clase hereda directamente de la ClaseA
 * Todos sus atributos y métodos
 * */
class ClaseB:public ClaseA
{
// Atributos protegidos
protected:
	int datoB;
// Atributos/Métodos públicos
public:
	// Constructor
    ClaseB() { datoB = 5; /*cout<<"ClaseB inicia a: "<<datoB<<endl;*/ }
	// Destructor
	~ClaseB() { cout<<"Fin de ClaseB"<<endl; }
	int LeerB() { return datoB; }
};

int main()
{
	// Se genera un objeto de ClaseB
	ClaseB obj;
	// A partir de este objeto se puede tener acceso a la ClaseA
	cout<<"a= "<<obj.LeerA()<<", b= "<<obj.LeerB()<<endl;
	return 0;
}