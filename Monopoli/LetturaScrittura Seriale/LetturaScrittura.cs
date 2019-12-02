using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CMonopoli
{
    class LetturaScrittura
    {
        SerialPort COM;
        public LetturaScrittura()
        {
            COM = new SerialPort("COM9", 9600);
            COM.Open();
        }
        public string LetturaPlayer()
        {
            String g = COM.ReadLine();
            return g;
        }
    }
}
