using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2.static_i_instanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (Klasa.ProstSlozen(broj))
            {
                Console.WriteLine("Broj je prost.");
            }
            else
            {
                Console.WriteLine("Broj je složen.");
            }

            Klasa k1 = new Klasa();
            if (k1.Savrsen(broj))
            {
                Console.WriteLine("Broj je savršen!");
            }
            else
            {
                Console.WriteLine("Broj nije savršen!");
            }

            Console.ReadKey();

        }
    }
}
