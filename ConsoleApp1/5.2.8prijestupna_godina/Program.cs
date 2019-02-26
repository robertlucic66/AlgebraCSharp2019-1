using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._8prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite godinu: ");
                int broj = int.Parse(Console.ReadLine());
                if ((broj % 4 == 0 && (!(broj % 100 == 0))) || (broj % 400 == 0))
                {
                    Console.WriteLine("Prijestupna");
                }
                else
                {
                    Console.WriteLine("Nije prijestupna godina");
                }
            }catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Greška");
            }
            Console.ReadKey();
        }
    }
}
