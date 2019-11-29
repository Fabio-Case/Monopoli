using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giocatore
{
    class CGiocatori
    {
        CCgiocatore[] giocatori;
        private int gioc;
        public CGiocatori(int g)
        {
            gioc = g;
            giocatori = new CCgiocatore[g];
            for (int i = 0; i < g; i++)
                giocatori[i] = new CCgiocatore(gioc);
        }
        
        private void cartellini()
        {
            int c = giocatori[0].distribuzioneContratti(gioc);
            
        }
    }
}
