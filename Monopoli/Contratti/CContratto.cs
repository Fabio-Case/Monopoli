using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratti
{
    public class CContratto
    {
        private int num;
        private String Nome;
        private String colori;
        private float valore_diContratto;
        private float valore_diIpoteca;
        private float costaCasa;
        private readonly float[] costi;
        private int casa;

        public String nome
        {
            get => Nome;
            set => Nome = value;
        }

        public float PrezzoContratto
        {
            get => valore_diContratto;
            set => valore_diContratto = value;
        }

        public float PrezzoIpoteteca
        {
            get => valore_diIpoteca;
            set => valore_diIpoteca = value;
        }
        public int Casa { get => casa; set => casa = value; }
        public int Num { get => num; set => num = value; }
        public float CostaCasa { get => costaCasa; set => costaCasa = value; }
        public string Colori { get => colori; set => colori = value; }

        public CContratto()
        {
            nome = "";
            PrezzoContratto = 0.0f;
            Num = 6;
            costi = new float[Num];
            PrezzoIpoteteca = 0.0f;
            Colori = "";
            Casa = 0;
        }

        public CContratto(String Nome, String colore, float valore_diContratto, float valore_diIpoteca, float[] prezzi, float casa)
        {
            //if (!"".Equals(Nome) && valore_diContratto != 0.0f && valore_diTerreno != 0.0f && valore_diIpoteca != 0.0f)
            //{
            //    this.Nome = Nome;
            //    this.valore_diContratto = valore_diContratto;
            //    this.valore_diTerreno = valore_diTerreno;
            //    this.valore_diIpoteca = valore_diIpoteca;
            //}
            nome = Nome;
            Colori = colore;
            PrezzoContratto = valore_diContratto;
            PrezzoIpoteteca = valore_diIpoteca;
            for (int i = 0; i < Num; i++)
                this.costi[i] = prezzi[i];
            CostaCasa = casa;
        }

        public float addCasa(int quantita)
        {
            int tot = Casa + quantita;
            if (tot < 6 && tot >= 0)
            {
                Casa = tot;
                return costaCasa*quantita;
            }
            else
                return -1;
        }
        public String VisualizzaContratto()
        {
            String ris = "";
            if (colori != "stazione" || colori != "Soc.")
                ris = "Nome: " + Nome + "\r\n\tColore: " + colori + "\r\n\tValore contratto: " + valore_diContratto +
                   "\r\n\tValore per comprare una casa" + CostaCasa + "\r\n\tValore di ipoteca: " + valore_diIpoteca;
            else
                ris = "Nome: " + nome + "\r \tValore contratto: " + valore_diContratto + "\n Valore di ipoteca: " + valore_diIpoteca;
            return ris;
        }
    }
}
