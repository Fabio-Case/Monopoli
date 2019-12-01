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

        public void SoldiPerGiocatore(int g)
        {
            float lire = 0;
            if (g == 2)
                lire = 200000 * 2;
            else if (g == 3)
                lire = 150000*3;
            else if (g == 4)
                lire = 100000 * 4;
            soldi -= lire;
        }


    }
}
