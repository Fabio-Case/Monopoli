// CVector.h

#ifndef _CVECTOR_h
#define _CVECTOR_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif
#include "CPosizione.h"
#define MAX 41
class CVectorClass : public CPosizioneClass
{
 private:
	 CPosizioneClass vector[MAX];
	 void reset(int g);
 public:
	void init();
	void setgiocatore(int g, int pos);
	String toString();
};

extern CVectorClass CVector;

#endif

