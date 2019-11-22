// CPosizione.h

#ifndef _CPOSIZIONE_h
#define _CPOSIZIONE_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif


class CPosizioneClass
{
 protected:
	 bool g1, g2, g3, g4;

 public:
	void init();
	String toString(int i);
	String toString();
	void setG1(bool g);
	void setG2(bool g);
	void setG3(bool g);
	void setG4(bool g);
};

extern CPosizioneClass CPosizione;

#endif

