using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaNagradna
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Ucenik> listaUcenika = new List<Ucenik>
            {
                new Ucenik("Marin", "Marinić"),
                new Ucenik("Ana", "Anić", "631975682649"),
                new Ucenik("Josip", "Josipović", "25691035619", 7240),
            };

                listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));
                Console.WriteLine("");
                listaUcenika.ForEach(Ucenik => UnesiBrojTelefona(Ucenik));
                listaUcenika.ForEach(Ucenik => UmanjiRacun(Ucenik));
                listaUcenika.ForEach(Ucenik => NoviIspis(Ucenik));

            }
            catch (FormatException fex)
            {
                Console.WriteLine("Greška. Poruka: " + fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }

            finally
            {
                Console.ReadKey();
            }
        }

        private static void NoviIspis(Ucenik ucenik)
        {
            Console.WriteLine("\nUčenik: {0} {1}", ucenik.Ime, ucenik.Prezime);
            Console.WriteLine("Broj telefona: {0}", ucenik.telefon);
            Console.WriteLine("Stanje računa: {0}", ucenik.Racun);
        }

        private static void UnesiBrojTelefona(Ucenik ucenik)
        {
            Console.WriteLine("Unesite broj telefona za: " + ucenik.Ime + " " + ucenik.Prezime);
            ucenik.telefon = Console.ReadLine();

            foreach (char c in ucenik.telefon)
            {
                if (c < '0' || c > '9')
                {
                    throw new Exception("Neispravan unos!");
                }                  
            }
        }

        private static void UmanjiRacun(Ucenik ucenik)
        {
            Console.WriteLine("Unesite iznos školarine za: " + ucenik.Ime + " " + ucenik.Prezime);
            double iznosSkolarine = double.Parse(Console.ReadLine());
            if(iznosSkolarine < 0)
            {
                throw new Exception("Neispravan unos!");
            }
            ucenik.Racun -= iznosSkolarine;
        }

        private static void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine(ucenik.ToString());
        }
    }
}
