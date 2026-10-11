using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CGiostraBambini : CAttrazioni
    {
        private const int prezzo = 2;
        private int etaMax;

        public CGiostraBambini(string nome, int capienza, int etaMax) : base(nome, capienza)
        {
            Prezzo = prezzo;
            this.etaMax = etaMax;
        }
        public override int CalcoloCosto(CVisitatore visitatore)
        {
            return Prezzo;
        }
        public bool Verifica(CVisitatore visitatore)
        {
            if (visitatore.Eta <= etaMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Tipologia: Giostra per Bambini, Prezzo: {Prezzo} euro";
        }
    }
}
