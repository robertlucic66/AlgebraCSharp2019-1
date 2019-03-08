using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik zaposlenik1 = new Zaposlenik("Pero", "Peric", "92358367485");

            bool ispravanUnos = false;
            while (!ispravanUnos)
            {
                Console.WriteLine("Unesite broj bodova: ");

                try
                {
                    zaposlenik1.BrojBodova = double.Parse(Console.ReadLine());
                    ispravanUnos = true;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Greška. Poruka: " + fex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška. Poruka: " + ex.ToString());
                }
            }

            // Ispis
            Console.WriteLine("Zaposlenik: " + zaposlenik1.Ime + " " + zaposlenik1.Prezime);
            Console.WriteLine("Neto: " + zaposlenik1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + zaposlenik1.Porez);
            Console.WriteLine("Bruto: " + zaposlenik1.BrutoIzracunPlace());

            Console.ReadKey();
        }
    }
}
