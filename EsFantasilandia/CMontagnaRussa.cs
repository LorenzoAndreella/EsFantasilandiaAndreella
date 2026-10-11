using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CMontagnaRussa : CAttrazioni
    {
        protected int AltezzaMinima { get; set; }
        private const int prezzo = 4;
        protected int Supplemento { get; set; } = 2;

        public CMontagnaRussa(string nome, int capienza, int altezzaMinima) : base(nome, capienza)
        {
            Prezzo = prezzo;
            AltezzaMinima = altezzaMinima;
        }

        public virtual bool Verifica(CVisitatore V)
        {
            if (V.Altezza >= AltezzaMinima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int CalcoloCosto(CVisitatore visitatore)
        {
            if (visitatore.FastPass)
            {
                return Prezzo + Supplemento;
            }
            else
            {
                return Prezzo;
            }

        }

        public override string ToString()
        {
            return base.ToString() + $", Tipologia: Montagna Russa, Prezzo: {Prezzo} euro, Altezza Minima: {AltezzaMinima}";
        }
    }
}
