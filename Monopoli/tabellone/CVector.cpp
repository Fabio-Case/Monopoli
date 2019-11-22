// 
// 
// 

#include "CVector.h"

void CVectorClass::reset(int g)
{
	if (g == 1)
		for (int i = 0; i < MAX; i++)
			vector[i].setG1(false);
	else if (g == 2)
		for (int i = 0; i < MAX; i++)
			vector[i].setG2(false);
	else if (g == 3)
		for (int i = 0; i < MAX; i++)
			vector[i].setG3(false);
	else if (g == 4)
		for (int i = 0; i < MAX; i++)
			vector[i].setG4(false);
}

void CVectorClass::init()
{
	for (int i = 0; i < MAX; i++)
		vector[i].init();
}

void CVectorClass::setgiocatore(int g, int pos)
{
	if (g == 1)
	{
		reset(g);
		vector[g].setG1(true);
	}
	else if (g == 2)
	{
		reset(g);
		vector[g].setG2(true);
	}
	else if (g == 3)
	{
		reset(g);
		vector[g].setG3(true);
	}
	else if (g == 4)
	{
		reset(g);
		vector[g].setG4(true);
	}

}

String CVectorClass::toString()
{
	String ris = "";
	for (int i = 0; i < MAX; i++)
		if(vector[i].toString(i) == "")
			ris += vector[i].toString(i) + "\n";
	return g1.toString();
}


CVectorClass CVector;
