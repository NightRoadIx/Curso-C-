#include <stdio.h>
#include <string.h>
#include <iostream>

using namespace std;

int& maxref(int& a, int& b);

int main(int argc, char **argv)
{
	int i = 1, j = 2;
	// Función inline, cuyos argumentos son referencia
	void permutar(int &a, int &b);
	
	printf("\ni = %d, j = %d", i, j);
	permutar(i,j);
	printf("\ni = %d, j = %d", i, j);
	maxref(i, j) = 0;
	printf("\ni = %d, j = %d", i, j);
	
	return 0;
}

void permutar(int &a, int &b)
{
	int temp;
	
	temp = a;
	a = b;
	b = temp;
}

int& maxref(int& a, int& b)
{
	if(a >= b)
		return a;
	else
		return b;
}