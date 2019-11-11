using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMonopoli
{
    class CImmobile
    {
        private static int MAXEL = 28;
        protected CContratto[] Immobile = new CContratto[MAXEL];

        private void swap(CContratto valore1, CContratto valore2)
        {
            CContratto temp;
            temp = valore1;
            valore1 = valore2;
            valore2 = temp;

        }
        private void creaContratti()
        {
            Immobile[0] = new CContratto("Vicolo Corto", "Fucsia", 6000, 3000, new float[] { 200, 1000, 3000, 9000, 16000, 25000 }, 5000);
            Immobile[1] = new CContratto("Vicolo Stretto", "Fucsia", 6000, 3000, new float[] { 400, 2000, 6000, 18000, 32000, 45000 }, 5000);
            Immobile[2] = new CContratto("Stazione Sud", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            Immobile[3] = new CContratto("Bastioni Gran Sasso", "Azzurro", 10000, 5000, new float[] { 600, 3000, 9000, 27000, 40000, 55000 }, 5000);
            Immobile[4] = new CContratto("Viale Monterosa", "Azzurro", 10000, 5000, new float[] { 600, 3000, 9000, 27000, 40000, 55000 }, 5000);
            Immobile[5] = new CContratto("Viale Vesuvio", "Azzurro", 12000, 6000, new float[] { 800, 4000, 10000, 30000, 45000, 60000 }, 5000);
            Immobile[6] = new CContratto("Via Accademia", "Arancio", 14000, 7000, new float[] { 1000, 5000, 15000, 45000, 62000, 75000 }, 10000);
            Immobile[7] = new CContratto("Soc. Elettrica", "Soc.", 15000, 7500, new float[] { 2000, 10000, 0, 0, 0, 0 }, 0);
            Immobile[8] = new CContratto("Corso Ateneo", "Arancio", 14000, 7000, new float[] { 1000, 5000, 15000, 45000, 62000, 75000 }, 10000);
            Immobile[9] = new CContratto("Piazza Università", "Arancio", 16000, 8000, new float[] { 1200, 6000, 18000, 50000, 70000, 90000 }, 10000);
            Immobile[10] = new CContratto("Stazione Ovest", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            Immobile[11] = new CContratto("Via Verdi", "Marrone", 18000, 9000, new float[] { 1400, 7000, 20000, 55000, 75000, 95000 }, 5000);
            Immobile[12] = new CContratto("Corso Raffaello", "Marrone", 18000, 9000, new float[] { 1400, 7000, 20000, 55000, 75000, 95000 }, 5000);
            Immobile[13] = new CContratto("Piazza Dante", "Marrone", 20000, 10000, new float[] { 1600, 8000, 22000, 60000, 80000, 100000 }, 10000);
            Immobile[14] = new CContratto("Via Marco Polo", "Rosso", 22000, 11000, new float[] { 1800, 9000, 25000, 70000, 88000, 105000 }, 15000);
            Immobile[15] = new CContratto("Corso Magellano", "Rosso", 22000, 11000, new float[] { 1800, 9000, 25000, 70000, 88000, 105000 }, 15000);
            Immobile[16] = new CContratto("Largo Colombo", "Rosso", 24000, 12000, new float[] { 2000, 10000, 3000, 75000, 90000, 110000 }, 15000);
            Immobile[17] = new CContratto("Stazione Nord", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            Immobile[18] = new CContratto("Viale Costantino", "Giallo", 26000, 13000, new float[] { 2200, 11000, 33000, 80000, 100000, 120000 }, 15000);
            Immobile[19] = new CContratto("Viale Traiano", "Giallo", 26000, 13000, new float[] { 2200, 11000, 33000, 80000, 100000, 120000 }, 15000);
            Immobile[20] = new CContratto("Soc. Acqua Potabile", "Soc.", 15000, 7500, new float[] { 2000, 10000, 0, 0, 0, 0 }, 0);
            Immobile[21] = new CContratto("Piazza Giulio Cesare", "Giallo", 28000, 14000, new float[] { 2400, 12000, 36000, 85000, 105000, 125000 }, 15000);
            Immobile[22] = new CContratto("Via Roma", "Verde", 30000, 15000, new float[] { 2600, 13000, 40000, 90000, 110000, 130000 }, 20000);
            Immobile[23] = new CContratto("Corso Impero", "Verde", 30000, 15000, new float[] { 2600, 13000, 40000, 90000, 110000, 130000 }, 20000);
            Immobile[24] = new CContratto("Largo Augusto", "Fucsia", 32000, 16000, new float[] { 2800, 15000, 45000, 100000, 120000, 140000 }, 20000);
            Immobile[25] = new CContratto("Stazione Est", "stazione", 20000, 10000, new float[] { 2500, 5000, 10000, 20000, 0, 0 }, 0);
            Immobile[26] = new CContratto("Viale dei Giardini", "Viola", 35000, 17500, new float[] { 3500, 20000, 50000, 110000, 130000, 150000 }, 20000);
            Immobile[27] = new CContratto("Parco della Vittoria", "Viola", 40000, 20000, new float[] { 5000, 20000, 60000, 140000, 170000, 200000 }, 20000);
        }

        public CImmobile() => creaContratti(); //inseriti tutti i contratti

        public String visualizzaListaContratti()
        {
            String ris = "";
            for (int i = 0; i < MAXEL; i++)
                ris += (Immobile[i].VisualizzaContratto()) + "\r\n";
            return ris;
        }

        public String visualizzaContratto(int pos) //superfluo
        {
            return Immobile[pos].VisualizzaContratto();
        }
        private void BoubbleSortName()
        {
            bool ordinato = false;
            while (ordinato == false)
            {
                ordinato = true;
                for (int i = 0; i < MAXEL - 1; i++)
                {
                    if (Immobile[i].PrezzoContratto > Immobile[i + 1].PrezzoContratto)
                    {
                        swap(Immobile[i], Immobile[i + 1]);
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
                if (Immobile[i].nome.Equals(elemCercato))
                    trovato = true;
                else
                    i++;
            }
            if (trovato)
                return i;
            else
                return -1;
        }
        public bool addCasa(int casa, String nome)
        {
            int i = getPosByName(nome);
            if (i != -1)
            {
                if (Immobile[i].addCasa(casa))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
