using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1.prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik();
            Ucenik uc2 = new Ucenik("Anica");
            Ucenik uc3 = new Ucenik("Perica", "Perić");

            // DODAJ VOZACE
            Vozac vo1 = new Vozac("Luka", "Krilić"); // Osoba
        }
    }
}
