/*
 * Otro ejemplo de clases
 * */
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include <iostream>

using namespace std;

class C_Cuenta
{
	// Variables miembro (encapsuladas)
private:
	char *nombre;
	double saldo;
	double interes;
	
	// Métodos (públicos para que sean llamados por el programa)
public:
	// TODAS SON INLINE (puede colocarse dicha palabra clave para indicarlo, pero no es necesario)
	// Constructor (con valores por defecto)
	C_Cuenta(const char *unNombre, double unSaldo = 0.0, double unInteres = 0.0)
	{
		nombre = new char[strlen(unNombre)+1];
		strcpy(nombre, unNombre);
		saldo = unSaldo;
		interes = unInteres;
	}
	// Destructor
	~C_Cuenta()
	{
		// Libera la memoria a la que se referencia el apuntador
		delete [] nombre;
	}
	char *getNombre()
	{
		return nombre;
	}
	double getSaldo()
	{
		return saldo;
	}
	double getInteres()
	{
		return interes;
	}
	void setSaldo(double unSaldo)
	{
		saldo = unSaldo;
	}
	void setInteres(double unInteres)
	{
		interes = unInteres;
	}
	void ingreso(double unaCantidad)
	{
		setSaldo( getSaldo() + unaCantidad );
	}
};

int main(void)
{
	/*
	 * Se realiza una operación en tres fases:
	 * 1.- Se genera un apuntador capaz de contener la dirección del objeto de la clase
	 * 2.- A continuación por medio del operador new se reserva memoria para un objeto del tipo C_Cuenta
	 * 3.- Finalmente se llama (de forma totalmente transparente al usuario) un constructor de la clase C_Cuenta
	 * */
	// C_Cuenta *c1 = new C_Cuenta();
	
	/*
	 * Llamadas al constructor
	 * Ya se mediante:
	 * C_Cuenta c2 = C_Cuenta(500.0, 10.0);
	 * o mediante
	 * C_Cuenta c2(500.0, 10.0);
	 * */
	 C_Cuenta C0("Igor");
	
	cout<<"Nobody tolds me \a\n";
}