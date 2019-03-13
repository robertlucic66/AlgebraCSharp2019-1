using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1.prirucnik
{
    internal interface IUcenik
    {
        double Prosjek();
        string ToString();
        void PrijaviIspit(Ispit ispit);
    }
}
