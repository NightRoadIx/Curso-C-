#include <iostream>

using namespace std;

class complejo
{

// Atributos/Métodos privados
private:
    double real;
    double imag;

// Atributos/Métodos públicos
public:
    // Constructores
    complejo(void)
    {
        real = 0.0;
        imag = 0.0;
    }

    complejo(double re, double im = 0.0)
    {
        real = re;
        imag = im;
    }

    complejo(const complejo &c)
    {
        real = c.real;
        imag = c.imag;
    }

    // Setters
    void setData(void)
    {
        cout << "Introduzca el valor real del complejo      : ";
        cin >> real;
        cout << "Introduzca el valor imaginario del complejo: ";
        cin >> imag;
    }
    void setReal(double re)
    {
        real = re;
    }
    void setImag(double im)
    {
        imag = im;
    }

    // Getters
    double getReal(void)
    {
        return real;
    }

    double getImag(void)
    {
        return imag;
    }

    // Operadores aritméticos
    complejo operator+ (const complejo &a)
    {
        complejo suma;
        suma.real = real + a.real;
        suma.imag = imag + a.imag;
        return suma;
    }
    complejo operator- (const complejo &a)
    {
        complejo resta;
        resta.real = real + a.real;
        resta.imag = imag + a.imag;
        return resta;
    }
    complejo operator* (const complejo &a)
    {
        complejo producto;
        producto.real = real*a.real - imag*a.imag;
        producto.imag = real*a.imag + a.real*imag;
        return producto;
    }
    complejo operator/ (const complejo &a)
    {
        complejo cociente;
        double d = a.real*a.real + a.imag*a.imag;
        cociente.real = (real*a.real + imag*a.imag)/d;
        cociente.imag = (-real*a.imag + imag*a.real)/d;
        return cociente;
    }
    // Operador de asignación
    complejo& operator= (const complejo &a)
    {
        real = a.real;
        imag = a.imag;
        return (*this);
    }
    // Operadores de comparación
    friend int operator== (const complejo &a, const complejo &b)
    {
        if (a.real==b.real && a.imag==b.imag)
            return 1;
        else
            return 0;
    }
    friend int operator!= (const complejo &a, const complejo &b)
    {
        if (a.real!=b.real && a.imag!=b.imag)
            return 1;
        else
            return 0;
    }
    // Operador de inserción
    friend ostream& operator<< (ostream &co, const complejo &a)
    {
        co << a.real;
        long fl = co.setf(ios::showpos);
        co << a.imag << "i";
        //co.flags(fl);
        return co;
    }

};

int main()
{
    // Crear dos complejos con el constructor
    complejo c1(1.0, 1.0);
    complejo c2(2.0,  2.0);
    // Crear uno con el constructor por defecto
    complejo c3;
    // Dar valor a la parte real e imaginaria
    c3.setReal(5.0);
    c3.setImag(2.0);
    // Crear un complejo con el valor por defecto en el imaginario
    complejo c4(4.0);

    // Crear uno a partir de la operación de otros dos
    complejo suma = c1 + c2;

    complejo resta, producto, cociente;
    resta = c1 - c2;
    producto = c1 * c2;
    cociente = c1 / c2;

    // Imprimir
    cout << c1 << ", " << c2 << ", " << c3 << ", " << c4 << endl;
    cout << "Primer complejo: " << c1 << endl;
    cout << "Segundo complejo: " << c2 << endl;
    cout << "Suma: " << suma << endl;
    cout << "Resta: " << resta << endl;
    cout << "Producto: " << producto << endl;
    cout << "Cociente: " << cociente << endl;

    // Comparar los números
    if (c1==c2)
        cout << "Los complejos son iguales." << endl;
    else
        cout << "Los complejos no son iguales." << endl;
    if (c1!=c2)
        cout << "Los complejos son diferentes." << endl;
    else
        cout << "Los complejos no son diferentes." << endl;

    return 0;
}
