using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class CBanca
    {
        private float soldi;

        CBanca() 
        {
            soldi = 2000000;
        }

        public float Soldi { get => soldi; set => soldi = value; }

        public float soldiPerGiocatore(int g)
        {
            float lire = 0;
            if (g == 2)
                lire = 350000;
            else if (g == 3)
                lire = 300000;
            else if (g == 4)
                lire = 250000;
            soldi -= lire;
            return lire;
        }


    }
}
