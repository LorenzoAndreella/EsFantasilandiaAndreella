using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    abstract class CAttrazioni : IRiparabile
    {
        private const int tempo = 5;
        protected int Prezzo { get; set; }
        private bool stato = false;
        private const int costoRip = 40;
        public string Nome { get; private set; }
        private int capienza;

        public CAttrazioni(string nome, int capienza)
        {
            Nome = nome;
            this.capienza = capienza;
        }

        public abstract int CalcoloCosto(CVisitatore visitatore);

        public override string ToString()
        {
            string statoStr = stato ? "Guasta" : "Funzionante";
            return $"Attrazione: {Nome}, Capienza: {capienza}, Stato: {statoStr}";
        }
        
        public bool IsGuasta()
        {
            return stato;
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

        public void SegnalaGuasto()
        {
            stato = true;
        }

    }
}
