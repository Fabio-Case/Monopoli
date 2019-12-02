using Contratti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMonopoli
{
    public class CGiocatori
    {
        CCgiocatore[] giocatori;
        CImmobile imm;
        private int gioc;
        public CGiocatori(int g)
        {
            gioc = g;
            giocatori = new CCgiocatore[g];
            for (int i = 0; i < g; i++)
                giocatori[i] = new CCgiocatore(gioc);
            imm = new CImmobile();
            cartellini();
        }
        
        private void cartellini()
        {
            try
            {
                int c = giocatori[0].distribuzioneContratti(gioc);
                CCgiocatore g = new CCgiocatore(gioc);
                int cartellini = g.distribuzioneContratti(gioc);
                int j = 0;
                for (int i = 0; i < gioc; i++)
                {
                    while (j < g.distribuzioneContratti(gioc))
                    {
                        giocatori[i].Contratti[j] = imm.visualizzaContratto(j);
                         j++;
                    }
                }
            }catch(Exception e)
            {

            }
            
        }
    }
}
