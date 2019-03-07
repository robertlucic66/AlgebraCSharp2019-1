using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1.proizvod
{
    class Proizvod
    {
        public string naziv = "";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;

        public Proizvod(string naziv)
        {
            this.naziv = naziv;
        }

        public double MPC()
        {
            return Cijena + Marza + Porez;
        }

    }

}
