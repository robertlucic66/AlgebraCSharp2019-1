using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1.prirucnik
{
    class Vozac : Osoba
    {
        bool kategorija_a = false;
        bool kategorija_b = false;
        bool kategorija_c = false;
        bool kategorija_d = false;
        bool kategorija_e = false;
        bool kategorija_f = false;
        private string v1;
        private string v2;

        public Vozac(string v1, string v2) : base (v1, v2)
        {
        }
    }
}
