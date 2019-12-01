using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAzioneInvolontariaObbligatoria
{
    class CImprevistiProbabilita
    {
        private const int MAXEL = 16;
        protected CElementi[] imprevisti = new CElementi[MAXEL];
        protected CElementi[] probabilita = new CElementi[MAXEL];


        CImprevistiProbabilita()
        {
            setProbabilita();
            setImprevisti();
            mischiaCartellini();
        }

        public void setProbabilita()
        {
            probabilita[0] = new CElementi("Andate fino al « Via! »",0,"Via");
            probabilita[1] = new CElementi("Andate in prigione direttamente e senza passare dal « Via! »",0,"Via");
            probabilita[2] = new CElementi("Avete perso una causa: pagate L. 10000",10000,"");
            probabilita[3] = new CElementi("Avete venduto delle azioni: ricavate 5.000 lire",5000,"");
            probabilita[4] = new CElementi("Avete vinto il secondo premio in un concorso di bellezza: ritirate 1.000 lire",1000,"");
            probabilita[5] = new CElementi("Avete vinto un premio di consolazione alla Lotteria di Merano: ritirate 10.000 lire",10000,"");
            probabilita[6] = new CElementi("E' il vostro compleanno: ogni giocatore vi regala 1.000 lire",1000,"");
            probabilita[7] = new CElementi("E' maturata la cedola delle vostre azioni: ritirate 2.500 lire",2500,"");
            probabilita[8] = new CElementi("Ereditate da un lontano parente 10.000 lire",10000,"");
            probabilita[9] = new CElementi("Pagate il conto del Dottore: 5.000 lire",5000,"");
            probabilita[10] = new CElementi("Pagate multa di 1.000 lire, oppure prendete un cartoncino dagli « imprevisti »",1000,"");
            probabilita[11] = new CElementi("Rimborso tassa sul reddito: ritirate 2.000 lire dalla Banca",2000,"");
            probabilita[12] = new CElementi("Ritornate al Vicolo Corto",0,"Vicolo Corto");
            probabilita[13] = new CElementi("Scade il Vostro premio di assicurazione: pagate 5.000 lire",5000,"");
            probabilita[14] = new CElementi("Siete creditore verso Banca di 20.000 lire: ritiratele",20000,"");
            probabilita[15] = new CElementi("Uscite gratis di prigione, se ci siete: potete conservare questo cartoncino sino al momento di servirvene(non si sa mai!) oppure venderlo",0,"");

        }
        public void setImprevisti()
        {

            imprevisti[0] = new CElementi("Andate alla Stazione NORD; se passate dal « Via! » ritirate le 20.000 lire",20000,"Stazione NORD");
            imprevisti[1] = new CElementi("Andate avanti sino al « Via! » ",0,"Via");
            imprevisti[2] = new CElementi("Andate fino al Parco della Vittoria",0,"Parco della Vittoria");
            imprevisti[3] = new CElementi("Andate in prigione direttamente e senza passare dal « Via! » ",0,"Via");
            imprevisti[4] = new CElementi("Andate sino a Via accademia: se passate dal « Via! » ritirate le 20.000 lire",20000,"Via Accademia/Via");
            imprevisti[5] = new CElementi("Andate sino al Largo Colombo: se passate dal « Via! » ritirate le 20.000 lire",20000,"Largo Colombo");
            imprevisti[6] = new CElementi("Avete tutti i vostri stabili da riparare: pagate 2.500 lire per ogni casa",2500,"");
            imprevisti[7] = new CElementi("Avete vinto un terno al lotto: ritirate 10.000 lire",10000,"");
            imprevisti[8] = new CElementi("Dovete pagare per contributo di miglioria stradale,10.000 lire per ogni albergo che possedete",10000,"");
            imprevisti[9] = new CElementi("Fate tre passi indietro(con tanti auguri)",0,"");
            imprevisti[10] = new CElementi("La Banca Vi paga gli interessi del vostro Conto Corrente: ritirate 5.000 lire",5000,"");
            imprevisti[11] = new CElementi("Matrimonio in famiglia: spese impreviste 15.000 lire",15000,"");
            imprevisti[12] = new CElementi("Maturano le cedole delle vostre cartelle di rendita, ritirate 15.000 lire",15000,"");
            imprevisti[13] = new CElementi("Multa di 1.500 lire per aver guidato senza patente",1500,"");
            imprevisti[14] = new CElementi("Uscite gratis di prigione, se ci siete: potete conservare questo cartoncino sino al momento di servirvene(non si sa mai!) oppure venderlo",0,"");
            imprevisti[15] = new CElementi("Versate 2000 lire per beneficenza",2000,"");

        }

        private void mischiaCartellini()
        {
            Random random = new Random();
            for (int i = 0, j = 0; i < MAXEL; i++)
            {
                j = random.Next(20);
                swap(ref imprevisti[j], ref imprevisti[i]);
                swap(ref probabilita[j], ref probabilita[i]);
            }
        }

        private void swap(ref CElementi c1, ref CElementi c2)
        {
            CElementi temp = c1;
            c1 = c2;
            c2 = temp;
        }

    }
}
