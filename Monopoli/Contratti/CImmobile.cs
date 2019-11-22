using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratti
{
    public class CImmobile
    {
        private const int MAXEL = 28;
        protected CContratto[] imm = new CContratto[MAXEL];

        private void swap(CContratto valore1, CContratto valore2)
        {
            CContratto temp;
            temp = valore1;
            valore1 = valore2;
            valore2 = temp;

        }
        private void creaContratti()
        {
            imm[0] = new CContratto("Vicolo Corto", "Fucsia", 6000, 3000, new float[] { 200, 1000, 3000, 9000, 16000, 25000 }, 5000);
            imm[1] = new CContratto("Vicolo Stretto", "Fucsia", 6000, 3000, new float[] { 400, 2000, 6000, 18000, 32000, 45000 }, 5000);
            imm[2] = new CContratto("Stazione Sud", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            imm[3] = new CContratto("Bastioni Gran Sasso", "Azzurro", 10000, 5000, new float[] { 600, 3000, 9000, 27000, 40000, 55000 }, 5000);
            imm[4] = new CContratto("Viale Monterosa", "Azzurro", 10000, 5000, new float[] { 600, 3000, 9000, 27000, 40000, 55000 }, 5000);
            imm[5] = new CContratto("Viale Vesuvio", "Azzurro", 12000, 6000, new float[] { 800, 4000, 10000, 30000, 45000, 60000 }, 5000);
            imm[6] = new CContratto("Via Accademia", "Arancio", 14000, 7000, new float[] { 1000, 5000, 15000, 45000, 62000, 75000 }, 10000);
            imm[7] = new CContratto("Soc. Elettrica", "Soc.", 15000, 7500, new float[] { 2000, 10000, 0, 0, 0, 0 }, 0);
            imm[8] = new CContratto("Corso Ateneo", "Arancio", 14000, 7000, new float[] { 1000, 5000, 15000, 45000, 62000, 75000 }, 10000);
            imm[9] = new CContratto("Piazza Università", "Arancio", 16000, 8000, new float[] { 1200, 6000, 18000, 50000, 70000, 90000 }, 10000);
            imm[10] = new CContratto("Stazione Ovest", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            imm[11] = new CContratto("Via Verdi", "Marrone", 18000, 9000, new float[] { 1400, 7000, 20000, 55000, 75000, 95000 }, 5000);
            imm[12] = new CContratto("Corso Raffaello", "Marrone", 18000, 9000, new float[] { 1400, 7000, 20000, 55000, 75000, 95000 }, 5000);
            imm[13] = new CContratto("Piazza Dante", "Marrone", 20000, 10000, new float[] { 1600, 8000, 22000, 60000, 80000, 100000 }, 10000);
            imm[14] = new CContratto("Via Marco Polo", "Rosso", 22000, 11000, new float[] { 1800, 9000, 25000, 70000, 88000, 105000 }, 15000);
            imm[15] = new CContratto("Corso Magellano", "Rosso", 22000, 11000, new float[] { 1800, 9000, 25000, 70000, 88000, 105000 }, 15000);
            imm[16] = new CContratto("Largo Colombo", "Rosso", 24000, 12000, new float[] { 2000, 10000, 3000, 75000, 90000, 110000 }, 15000);
            imm[17] = new CContratto("Stazione Nord", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            imm[18] = new CContratto("Viale Costantino", "Giallo", 26000, 13000, new float[] { 2200, 11000, 33000, 80000, 100000, 120000 }, 15000);
            imm[19] = new CContratto("Viale Traiano", "Giallo", 26000, 13000, new float[] { 2200, 11000, 33000, 80000, 100000, 120000 }, 15000);
            imm[20] = new CContratto("Soc. Acqua Potabile", "Soc.", 15000, 7500, new float[] { 2000, 10000, 0, 0, 0, 0 }, 0);
            imm[21] = new CContratto("Piazza Giulio Cesare", "Giallo", 28000, 14000, new float[] { 2400, 12000, 36000, 85000, 105000, 125000 }, 15000);
            imm[22] = new CContratto("Via Roma", "Verde", 30000, 15000, new float[] { 2600, 13000, 40000, 90000, 110000, 130000 }, 20000);
            imm[23] = new CContratto("Corso Impero", "Verde", 30000, 15000, new float[] { 2600, 13000, 40000, 90000, 110000, 130000 }, 20000);
            imm[24] = new CContratto("Largo Augusto", "Verde", 32000, 16000, new float[] { 2800, 15000, 45000, 100000, 120000, 140000 }, 20000);
            imm[25] = new CContratto("Stazione Est", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            imm[26] = new CContratto("Viale dei Giardini", "Viola", 35000, 17500, new float[] { 3500, 20000, 50000, 110000, 130000, 150000 }, 20000);
            imm[27] = new CContratto("Parco della Vittoria", "Viola", 40000, 20000, new float[] { 5000, 20000, 60000, 140000, 170000, 200000 }, 20000);
        }

        public CImmobile() => creaContratti(); //inseriti tutti i contratti

        public String visualizzaListaContratti()
        {
            String ris = "";
            for (int i = 0; i < MAXEL; i++)
                ris += (imm[i].VisualizzaContratto()) + "\r\n";
            return ris;
        }

        public String visualizzaContratto(int pos) //superfluo
        {
            return imm[pos].VisualizzaContratto();
        }
        private void BoubbleSortName()
        {
            bool ordinato = false;
            while (ordinato == false)
            {
                ordinato = true;
                for (int i = 0; i < MAXEL - 1; i++)
                {
                    if (imm[i].PrezzoContratto > imm[i + 1].PrezzoContratto)
                    {
                        swap(imm[i], imm[i + 1]);
                        ordinato = false;
                    }
                }
            }
        }

        private int getPosByName(String elemCercato)
        {
            bool trovato = false;
            int i = 0;
            while (trovato == false && i < MAXEL)
            {
                if (imm[i].nome.Equals(elemCercato))
                    trovato = true;
                else
                    i++;
            }
            if (trovato)
                return i;
            else
                return -1;
        }
        public float addCasa(int casa, String nome)
        {
            int i = getPosByName(nome);
            if (i != -1)
            {
                if (imm[i].addCasa(casa) != -1)
                    return imm[i].addCasa(casa);
                else
                    return -1;
            }
            else
                return -1;
        }
    }
}
