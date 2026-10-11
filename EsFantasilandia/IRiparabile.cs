using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal interface IRiparabile
    {
        bool IsGuasta();
        int Ripara();
        void SegnalaGuasto();
    }
}
