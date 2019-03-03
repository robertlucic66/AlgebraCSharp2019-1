using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._18.unos_ocjene
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.18 Unos ocjene
            /* Napišite program koji traži unos ocjene. Dok god unesena ocjena ne bude ispravno unesena
             * (cijeli broj iz intervala [1, 5], program traži ponovni unos. * */
            string ocjena = "";
            bool ispravanUnos = false;

            while (!ispravanUnos)
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = Console.ReadLine();

                if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                {
                    ispravanUnos = true;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos!");
                }
            }
            Console.WriteLine("Ocjena je ispravno unešena.");
            Console.ReadLine();
        }
    }
}
