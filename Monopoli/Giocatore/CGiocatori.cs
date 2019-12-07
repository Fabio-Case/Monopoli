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
            
        }
        public string setup()
        {
            string ris;
            giocatori = new CCgiocatore[gioc];
            for (int i = 0; i < gioc; i++)
                giocatori[i] = new CCgiocatore(gioc);
            imm = new CImmobile();
            ris = cartellini();
            return ris;
        }
        private string cartellini()
        {
            string ecc = "\0";
            int c = giocatori[0].distribuzioneContratti(gioc);
            CCgiocatore g = new CCgiocatore(gioc);
            int cartellini = g.distribuzioneContratti(gioc);
            int j = 0;
            for (int i = 0; i < gioc; i++)
            {
                try
                {
                    while (j < g.distribuzioneContratti(gioc))
                    {
                        giocatori[i].Contratti[40] = imm.visualizzaContratto(j);
                        j++;
                    }
                }
                catch(System.IndexOutOfRangeException e)
                {
                    return "Oltre i limiti della matrice";
                }
                catch(Exception e)
                {
                    return e.ToString();   
                }
            }
            return ecc;
        }
        
    }
}
