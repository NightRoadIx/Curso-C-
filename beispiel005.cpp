/*Animales.cpp
  Programa de Herencia*/
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

#include <iostream>

using namespace std;

/*Clase Animales*/
class animales
{
protected:
	char *orden;
	char *familia;
	char *habitat;
	float tamano;
	int longevid;
	char *alimentac;
public:
	animales();
	~animales();
	void acept();
	void print();
};

animales::animales()
{
	orden=new char[20];
	familia=new char[20];
	habitat=new char[20];
	tamano=0.00;
	longevid=0;
	alimentac=new char[20];
};

animales::~animales()
{
	delete []orden;
	delete []familia;
	delete []habitat;
	tamano=0.00;
	longevid=0;
	delete []alimentac;
};

void animales::acept()
{
	cin.ignore(20, '\n');
	cout<<"Teclea el orden:       ";
	cin.getline(orden, 20);
	cout<<"Teclea la familia:     ";
	cin.getline(familia, 20);
	cout<<"Teclea el habitat:     ";
	cin.getline(habitat, 20);
	cout<<"Teclea el tamaño:      ";
	cin>>tamano;
	cout<<"Teclea la longevidad:  ";
	cin>>longevid;
	cin.ignore(20, '\n');
	cout<<"Tecle su alimentacion: ";
	cin.getline(alimentac, 20);
};

void animales::print()
{
	cout<<"Orden:        "<<orden<<endl;
	cout<<"Familia:      "<<familia<<endl;
	cout<<"Habitat:      "<<habitat<<endl;
	cout<<"Tamaño:       "<<tamano<<endl;
	cout<<"Longevidad:   "<<longevid<<endl;
	cout<<"Alimentación: "<<alimentac<<endl;
};

/*Clase Mamiferos (Hereda de animales)*/
class mamiferos:public animales
{
protected:
	int t_gest;
	char *tip_parto;
public:
	mamiferos();
	~mamiferos();
};

mamiferos::mamiferos()
{
	t_gest=0;
	tip_parto=new char[20];
};

mamiferos::~mamiferos()
{
	t_gest=0;
	delete []tip_parto;
};

/*Clase Reptiles (Hereda de animales)*/
class reptiles:public animales
{
protected:
	int t_muda;
public:
	reptiles();
	~reptiles();
};

reptiles::reptiles()
{
	t_muda=0;
};

reptiles::~reptiles()
{
	t_muda=0;
};

/*Clase Aves (Hereda de animales)*/
class aves:public animales
{
protected:
	int num_huevos;
	char *tipo_ala;
public:
	aves();
	~aves();
};

aves::aves()
{
	num_huevos=0;
	tipo_ala=new char[20];
};

aves::~aves()
{
	num_huevos=0;
	delete []tipo_ala;
};

/*Clase gato (Hereda de mamiferos)*/
class gato:public mamiferos
{
private:
	char *raza;
public:
	gato();
	~gato();
	void aceptar();
	void imprimir();
};

gato::gato()
{
	raza=new char[20];
};

gato::~gato()
{
	delete []raza;
};

void gato::aceptar()
{
	cout<<"-*-*-*-*-*- GATO -*-*-*-*-*-"<<endl;
	acept();
	cout<<"Teclea el tiempo de gestación:                 ";
	cin>>t_gest;
	cin.ignore(20, '\n');
	cout<<"Teclea el tipo de parto [vivipara, marsupial]: ";
	cin.getline(tip_parto, 20);
	cout<<"Teclea la raza:    ";
	cin.getline(raza, 20);
};

void gato::imprimir()
{
	cout<<"-*-*-*-*-*- GATO -*-*-*-*-*-"<<endl;
	print();
	cout<<"Tiempo de Gestación: "<<t_gest<<endl;
	cout<<"Tipo de Parto:       "<<tip_parto<<endl;
	cout<<"Raza:                "<<raza<<endl;
};

/*Clase iguana (Hereda de reptiles)*/
class iguana:public reptiles
{
public:
	iguana() { };
	~iguana() { };
	void aceptar();
	void imprimir();
};

void iguana::aceptar()
{
	cout<<"-*-*-*-*-*- IGUANA -*-*-*-*-*-"<<endl;
	acept();
	cin.ignore(20, '\n');
	cout<<"Teclea el tiempo de muda de piel: ";
	cin>>t_muda;
};

void iguana::imprimir()
{
	cout<<"-*-*-*-*-*- IGUANA -*-*-*-*-*-"<<endl;
	print();
	cout<<"Tiempo de muda de piel: "<<t_muda<<endl;
};

/*Clase aves (Hereda de aves)*/
class aguila:public aves
{
private:
	char *tipo;
public:
	aguila();
	~aguila();
	void aceptar();
	void imprimir();
};

aguila::aguila()
{
	tipo=new char[20];
};

aguila::~aguila()
{
	delete []tipo;
};

void aguila::aceptar()
{
	cout<<"-*-*-*-*-*- AGUILA -*-*-*-*-*-"<<endl;
	acept();
	cout<<"Teclea el numero de huevosque pone:   ";
	cin>>num_huevos;
	cin.ignore(20, '\n');
	cout<<"Teclea el tipo de ala que posee:      ";
	cin.getline(tipo_ala, 20);
	cout<<"Teclea el tipo [necrofaga, monera, de presa]: ";
	cin.getline(tipo, 20);
};

void aguila::imprimir()
{
	cout<<"-*-*-*-*-*- AGUILA -*-*-*-*-*-"<<endl;
	print();
	cout<<"Numero de Huevos que pone: "<<num_huevos<<endl;
	cout<<"Tipo de ala:               "<<tipo_ala<<endl;
	cout<<"Tipo de aguila:            "<<tipo<<endl;
};

/*Función main*/
int main(void)
{
	int opc;
	gato ng;
	iguana ni;
	aguila na;
	do
	{
		system("cls");
		cout<<"***** MENU *****"<<endl<<endl;
		cout<<"1.-gato"<<endl;
		cout<<"2.-iguana"<<endl;
		cout<<"3.-aguila"<<endl;
		cout<<"4.-Salir"<<endl<<endl;
		cout<<"Opción...";
		cin>>opc;
		switch (opc)
		{
		case 1:
			ng.aceptar();
		    /*cout<<"Seguir -->";*/  getch(); 
			system("cls");
			ng.imprimir(); getch();
			break;
		case 2:
			ni.aceptar();
			//cout<<endl;
			/*cout<<"Seguir -->";*/  getch(); 
			system("cls");
			ni.imprimir(); getch();
			break;
		case 3:
			na.aceptar();
			//cout<<endl;
			/*cout<<"Seguir -->";*/ getch(); 
			system("cls"); 
			na.imprimir(); getch();
			break;
		}
	}
	while(opc != 4);
	
	return 0;
}