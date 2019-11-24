using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAzioneInvolontariaObbligatoria
{
    class CElementi
    {
        private string _cartellino;
        private string _posizione;
        private int _denaro;

        public CElementi()
        {
            _cartellino = "";
            _posizione = "";
            _denaro = 0;
        }

        public CElementi(string cartellino,int denaro,string posizione)
        {
            this._cartellino = cartellino;
            this._denaro = denaro;
            this._posizione = posizione;
        }

        public int denaro
        {
            get { return _denaro; }
        }

        public String cartellino
        {
            get { return _cartellino; }
        }

        public String posizione
        {
            get { return _posizione; }
        }


    }
}
