﻿using Contratti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giocatore
{
    public class CCgiocatore
    {
        private CContratto[] contratti;
        private int soldi;
        private decimal pos;

        public CContratto[] Contratti { get => contratti; set => contratti = value; }
        public int Soldi { get => soldi; set => soldi = value; }
        public decimal Pos { get => pos; set => pos = value; }

        public CCgiocatore(int g)
        {
            pos = 0;
        }

        public int distribuzioneContratti(int g)
        {
            if (g == 2)
            {
                int c = 14;
                contratti = new CContratto[c];
                return 28 / 2;
            }
            else if (g == 3)
            {
                int c = 9;
                contratti = new CContratto[c];
                return 27 / 3;
            }
            else if (g == 4)
            {
                int c = 7;
                contratti = new CContratto[c];
                return 28 / 4;
            }
            else
                return 0;
        }

        private void distrubuzioneSoldi(int g) 
        {
            switch (g)
            {
                case 2:
                    soldi = 200000;
                    break;
                case 3:
                    soldi = 150000;
                    break;
                case 4:
                    soldi = 100000;
                    break;
            }
        }
    }
}
