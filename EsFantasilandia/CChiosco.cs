using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CChiosco : IRiparabile
    {
        private int tempo = 5;
        private bool stato = false;
        private int costoRip = 40;
        private int numeroCibi;
        private string nome;

        public CChiosco(string nome, int numeroCibi)
        {
            this.nome = nome;
            this.numeroCibi = numeroCibi;
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
        public bool IsGuasta()
        {
            return stato;
        }
        public void SegnalaGuasto()
        {
            stato = true;
        }
        public override string ToString()
        {
            string statoStr = stato ? "Guasto" : "Funzionante";
            return $"Chiosco: {nome}, Numero di Cibi: {numeroCibi}, Stato: {statoStr}";
        }
    }
}
