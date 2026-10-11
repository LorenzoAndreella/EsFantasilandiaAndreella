using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CBagno : IRiparabile
    {
        private const int tempo = 5;
        private bool stato = false;
        private const int costoRip = 40;
        private int numeroBagni;
        public CBagno(int numeroBagni)
        {
            this.numeroBagni = numeroBagni;
        }
        public bool IsGuasta()
        {
            return stato;
        }
        public void SegnalaGuasto()
        {
            stato = true;
        }
        public int Ripara()
        {
            if (stato)
            {
                stato = false;
                return costoRip * tempo;
            }
            return 0;
        }
        public override string ToString()
        {
            string statoStr = stato ? "Guasto" : "Funzionante";
            return $"Bagno: Numero di Bagni: {numeroBagni}, Stato: {statoStr}";
        }
    }
}
