/*
 Name:		tabellone.ino
 Created:	03/11/2019 21:44:07
 Author:	Fabio
*/

// the setup function runs once when you press reset or power the board
#include "CVector.h"
CVectorClass p;
const int g1 = 2, g2 = 3, g3 = 4, g4 = 5;
int pin[MAX];
void settingP();

void setup() {
	p.init();
	settingP();
	pinMode(g1, INPUT);
	pinMode(g2, INPUT);
	pinMode(g3, INPUT);
	pinMode(g4, INPUT);
	for (int i = 0; i < MAX; i++)
		pinMode(pin[i], INPUT);

	Serial.begin(9600);
}

// the loop function runs over and over again until power down or reset
void loop() {
	bool g1 = false, g2 = false, g3 = false, g4 = false;
	int pos = 0;
	if (digitalRead(g1) == LOW) g1 = true;
	if (digitalRead(g2) == LOW) g2 = true;
	if (digitalRead(g3) == LOW) g3 = true;
	if (digitalRead(g4) == LOW) g4 = true;

	for (int i = 0; i < MAX; i++)
		if (digitalRead(pin[i]) == HIGH) pos = i;

	if (g1 == true)
		p.setgiocatore(1, pos);
	if (g2 == true)
		p.setgiocatore(1, pos);
	if (g3 == true)
		p.setgiocatore(1, pos);
	if (g4 == true)
		p.setgiocatore(1, pos);

	Serial.println(p.toString());
}

void settingP()
{
	pin[0] = 7;
	int pos = 14;
	for (int i = 1; i < MAX; i++)
	{
		pin[i] = pos;
		pos++;
	}
}


