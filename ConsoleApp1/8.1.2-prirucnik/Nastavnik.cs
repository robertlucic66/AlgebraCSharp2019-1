﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_prirucnik
{
    class Nastavnik
    {
        private string ime = "Antonije Marcus";
        private int oib;

        // read only
        public string Ime { get => ime;  }

        // write only
        public int Oib {  set => oib = value; }
        public int PartialOib { get => int.Parse(oib.ToString().Substring(0, 3)); }

        public static string Opis()
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama.";
        }

        public static float Koeficjent()
        {
            return 1.5f;
        }
    }
}