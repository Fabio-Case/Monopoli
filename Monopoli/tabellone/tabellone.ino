/*
 Name:		tabellone.ino
 Created:	03/11/2019 21:44:07
 Author:	Fabio
*/

// the setup function runs once when you press reset or power the board

const int g1 = 2, g2 = 3, g3 = 4, g4 = 5,  MAX = 40;
const int cS = 6, cN = 7, cC = 8, cP = 9; //cS = SI, cN = NO, cC = compra case, cP = prosegui
const int lErr = 13; //led di errore utilizzato per test
int static posG1 = 0, posG2 = 0, posG3 = 0, posG4 = 0;
int pin[MAX];
void settingP();
bool chiTocca(String g, int num);
int numG, giocatore;
String stringLetta;
void lettura();
void invioPos(int giocatoreNum);

void setup() {
	Serial.begin(9600);
	settingP();
	lettura();
	if (stringLetta == "n2") {
		pinMode(g1, INPUT);
		pinMode(g2, INPUT);
		numG = 2;
	}
	else if (stringLetta == "n3") {
		pinMode(g1, INPUT);
		pinMode(g2, INPUT);
		pinMode(g3, INPUT);
		numG = 3;
	}
	else if (stringLetta == "n4") {
		pinMode(g1, INPUT);
		pinMode(g2, INPUT);
		pinMode(g3, INPUT);
		pinMode(g4, INPUT);
		numG = 4;
	}
	pinMode(cS, INPUT);
	pinMode(cN, INPUT);
	pinMode(cC, INPUT);
	pinMode(cP, INPUT);
	pinMode(lErr, OUTPUT);
	for (int i = 0; i < MAX; i++)
		pinMode(pin[i], INPUT);
}

// the loop function runs over and over again until power down or reset
void loop() {
	lettura(); //in base a che giocatore tocca
	if (chiTocca(stringLetta, numG));

}

void settingP()
{
	int pos = 14;
	for (int i = 0; i < MAX; i++)
	{
		pin[i] = pos;
		pos++;
	}
}

bool chiTocca(String g, int num)
{
	String gioc = "";
	switch (num)
	{
	case 2:
		if (digitalRead(g1) == LOW) {
			gioc = "g1"; 
			giocatore = 1;
		}
		else if (digitalRead(g2) == LOW) {
			gioc = "g2";
			giocatore = 2;
		}
		break;
	case 3:
		if (digitalRead(g1) == LOW) {
			gioc = "g1";
			giocatore = 1;
		}
		else if (digitalRead(g2) == LOW) {
			gioc = "g2";
			giocatore = 2;
		}
		else if (digitalRead(g3) == LOW) {
			gioc = "g3";
			giocatore = 3;
		}
		break;
	case 4:
		if (digitalRead(g1) == LOW) {
			gioc = "g1";
			giocatore = 1;
		}
		else if (digitalRead(g2) == LOW) {
			gioc = "g2";
			giocatore = 2;
		}
		else if (digitalRead(g3) == LOW) {
			gioc = "g3";
			giocatore = 3;
		}
		else if (digitalRead(g4) == LOW) {
			gioc = "g4";
			giocatore = 4;
		}
		break;
	default:
		break;
	}
	if (g == gioc) {
		Serial.println("gC"); //giocatore corretto
		return true;
	}
	else {
		Serial.println("gE"); //giocatore errato
		return false;
	}
}

void lettura()
{
	char v[2];
	if (Serial.available() > 0) {
		v[0] = Serial.read();
		while (Serial.available() == 0);
		if (Serial.available() > 0)
			v[1] = Serial.read();
	}
	stringLetta = v;
}

void invioPos(int posgiocatore)
{
	int pos, posGiocatore;
	bool circuitoAperto = true;
	for (int i = 0; i < MAX && circuitoAperto; i++)
		if (digitalRead(pin[i]) == HIGH) {
			pos = i;
			circuitoAperto = false;
		}

	switch (giocatore)
	{
	case 1:
		if (pos - posG1 > 1 && pos - posG1 < 13)
			Serial.println(pos);
		else
			Serial.println("EP"); //errore posizione
		break;
	case 2:
		if (pos - posG2 > 1 && pos - posG2 < 13)
			Serial.println(pos);
		else
			Serial.println("EP"); //errore posizione
		break;
	case 3:
		if (pos - posG3 > 1 && pos - posG3 < 13)
			Serial.println(pos);
		else
			Serial.println("EP"); //errore posizione
		break;
	case 4:
		if (pos - posG4 > 1 && pos - posG4 < 13)
			Serial.println(pos);
		else
			Serial.println("EP"); //errore posizione
		break;
	default:
		break;
	}

}


