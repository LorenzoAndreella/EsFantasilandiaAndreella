using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CSalaGiochi : CAttrazioni
    {
        private const int prezzo = 2;

        public CSalaGiochi(string nome, int capienza) : base(nome, capienza)
        {
            Prezzo = prezzo;
        }
        public override int CalcoloCosto(CVisitatore visitatore)
        {
            return Prezzo;
        }
        public override string ToString()
        {
            return base.ToString() + $", Tipologia: Sala dei Giochi, Gettoni: {Prezzo}";
        }
    }
}
