// 
// 
// 
#include "CPosizione.h"

void CPosizioneClass::init()
{
	g1 = false;
	g2 = false;
	g3 = false;
	g4 = false;
}

String CPosizioneClass::toString(int i)
{
	String ris = "";
	if (g1) ris += "Giocatore 1 e' in posizione: " + String(i);
	if (g2) ris += "Giocatore 2 e' in posizione: " + String(i);
	if (g3) ris += "Giocatore 3 e' in posizione: " + String(i);
	if (g4) ris += "Giocatore 4 e' in posizione: " + String(i);
	return ris;
}

void CPosizioneClass::setG1(bool g)
{
	g1 = g;
}

void CPosizioneClass::setG2(bool g)
{
	g2 = g;
}

void CPosizioneClass::setG3(bool g)
{
	g3 = g;
}

void CPosizioneClass::setG4(bool g)
{
	g4 = g;
}




CPosizioneClass CPosizione;

