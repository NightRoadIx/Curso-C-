#include <stdio.h>
#include <string.h>
#include <iostream>

using namespace std;

// Sobrecarga de funciones
void string_copy(char *copia, const char *original);
void string_copy(char *copia, const char *original, const int longitud);

static char string_a[20], string_b[20];

int main(int argc, char **argv)
{
	string_copy(string_a, "Aquello");
	string_copy(string_b, "Esto es una cadena", 4);
	cout << string_b << " y " << string_a;
	return 0;
}

void string_copy(char *copia, const char *original)
{
	strcpy(copia, original);
}

void string_copy(char *copia, const char *original, const int longitud)
{
	strncpy(copia, original, longitud);
}