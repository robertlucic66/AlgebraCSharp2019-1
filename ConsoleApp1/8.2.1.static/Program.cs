using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1.staticprimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite 1. broj: ");
            double broj1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite 2. broj: ");
            double broj2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj je {0}.", StaticMetode.Zbroj(broj1, broj2));

            Console.WriteLine("Unesite broj za kubiranje: ");
            double broj = double.Parse(Console.ReadLine());
            Console.WriteLine(StaticMetode.Kub(broj));

            Console.Write("Unesite x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljenost točaka: " + StaticMetode.UdaljenostTocaka(x1, x2, y1, y2));

            Console.Write("Unesite stupnjeve Celzijuse: ");
            broj = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + StaticMetode.CelzijFahrenheit(broj));

            Console.ReadKey();
        }
    }
}
