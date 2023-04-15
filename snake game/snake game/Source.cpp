#include<iostream>
#include<conio.h>
#include<Windows.h>
using namespace std;
bool krajIgre;
const int sirina = 20;
const int visina = 20;
int x, y, voceX, voceY, rezultat;
int repX[100], repY[100];
int nRep; //duzina repa
enum kretnja { STANI = 0, LIJEVO, DESNO, GORE, DOLE };
kretnja krt;
void Setup() {
	krajIgre = false;
	krt = STANI;
	x = sirina / 2;
	y = visina / 2;
	voceX = rand() % sirina;
	voceY = rand() % visina;
	rezultat = 0;
}
void Crtez() {
	system("cls"); //brise prozor konzole
	for (int i = 0; i < sirina+2; i++)
	{
		cout << "#";
	}
	cout << endl;

	for (int i = 0; i < visina; i++)
	{
		for (int j = 0; j < sirina; j++)
		{
			if (j == 0)
				cout << "#";
			if (i == y && j == x)
				cout << "O";
			else if (i == voceY && j == voceX)
				cout << "F";
			else {
				bool ispis = false;
				for (int k = 0; k < nRep; k++)
				{
					if (repX[k] == j && repY[k] == i) {
						cout << "o";
						ispis = true;
					}
				}
				if (!ispis)
					cout << " ";
			}

			if (j == sirina - 1)
				cout << "#";
		}
		cout << endl;
	}

	for (int i = 0; i < sirina+2; i++)
	{
		cout << "#";
	}
	cout << endl;
	cout << "Rezultat: " << rezultat << endl;
}
void Unos() {
	if (_kbhit()) {
		switch (_getch())
		{
		case 'a':
			krt = LIJEVO;
			break;
		case 'd':
			krt = DESNO;
			break;
		case 'w':
			krt = GORE;
			break;
		case 's':
			krt = DOLE;
			break;
		case 'x':
			krajIgre = true;
			break;
		}
	}
}
void Logika() {
	int prijeX = repX[0];
	int prijeY = repY[0];
	int prije2X, prije2Y;
	repX[0] = x;
	repY[0] = y;
	for (int i = 1; i < nRep; i++)
	{
		prije2X = repX[i];
		prije2Y = repY[i];
		repX[i] = prijeX;
		repY[i] = prijeY;
		prijeX = prije2X;
		prijeY = prije2Y;
	}
	switch (krt)
	{
	case LIJEVO:
		x--;
		break;
	case DESNO:
		x++;
		break;
	case GORE:
		y--;
		break;
	case DOLE:
		y++;
		break;
	default:
		break;
	}

	/*if (x > sirina || x < 0 || y > visina || y < 0)
		krajIgre = true;*/

	//gornji dio koda je kraj igre ako se dodirne zid
	//donji dio igre dopusta prolazak kroz zid kraj igre je samo ako dodirnete vlastiti rep

	if (x >= sirina) x = 0; else if (x < 0) x = sirina - 1;
	if (y >= sirina) y = 0; else if (y < 0) y = visina - 1;

	for (int i = 0; i < nRep; i++)
	{
		if (repX[i] == x && repY[i] == y)
			krajIgre = true;
	}
	if (x == voceX && y == voceY) {
		rezultat += 10;
		voceX = rand() % sirina;
		voceY = rand() % visina;
		nRep++;
	}
}
int main() {
	Setup();
	while (!krajIgre) {
		Crtez();
		Unos();
		Logika();
		Sleep(10);
	}


	return 0;
}