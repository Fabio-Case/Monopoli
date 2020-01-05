/*
 Name:		tabellone.ino
 Created:	03/11/2019 21:44:07
 Author:	Fabio
*/

// the setup function runs once when you press reset or power the board

const int g1 = 9, g2 = 10, g3 = 11, g4 = 12,  MAX = 4;
const int cS = 3, cN = 4, cC = 5, cP = 6; //cS = SI, cN = NO, cC = compra case, cP = prosegui

int static posG1 = 0, posG2 = 0, posG3 = 0, posG4 = 0;
int pin[MAX];
void settingP();
bool chiTocca(String g, int num);
int numG, giocatore;
String stringLetta;
void lettura();
void invioPos();
void compraCase();
bool pagamento();

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
	for (int i = 0; i < MAX; i++)
		pinMode(pin[i], INPUT);
}

// the loop function runs over and over again until power down or reset
void loop() {
	lettura(); //in base a che giocatore tocca
	if (chiTocca(stringLetta, numG));
	compraCase();
	pagamento();
}

void settingP()
{
	int pos = 14;
  pin[0] = 2;
  int i;
	for (i = 1; i < 27; i++)
	{
		pin[i] = pos;
		pos++;
	}
  pos++;
  for (i = 27; i < MAX; i++)
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

void invioPos()
{
	int pos;
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

void compraCase()
{
	int count = 0;
	do {
		if (digitalRead(cC) == HIGH) {
			while (digitalRead(cC) == HIGH) {}
			count++;
		}
	} while (digitalRead(cS) == LOW && digitalRead(cN) == LOW && count < 6);
	Serial.print("C" + count);
}

bool pagamento()
{
	lettura();
	if (stringLetta == "CP") {
		if (digitalRead(cS) == HIGH) {
			Serial.println("SI");
			return true;
		}
		else if (digitalRead(cN) == HIGH) {
			Serial.println("NO");
			return true;
		}
		else {
			Serial.println("nC"); // non confermato ma premuto un altro tasto
			return false;
		}
	}
	else
		return false;
}
