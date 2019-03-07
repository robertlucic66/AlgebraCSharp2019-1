using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2.automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();
            Console.Write("Unesite marku automobila: ");
            automobil.MarkaAutomobila = Console.ReadLine();
            Console.Write("Unesite snagu u KS: ");
            automobil.KS = double.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());
            Console.Write("Iznos poreza je {0}, a ukupna cijena {1}.", automobil.IznosPoreza(), automobil.UkupnaCijena());
            Console.ReadKey();
        }
    }
}
