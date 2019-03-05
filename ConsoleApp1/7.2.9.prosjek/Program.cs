using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._9.prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool unosObavljen = false;
            try
            {
                while (!unosObavljen)
                {
                    Console.Write("Unesite prosječnu ocjenu: ");
                    double broj = double.Parse(Console.ReadLine());
                    if (broj >= 1 && broj <= 5)
                    {
                        unosObavljen = true;
                        Console.WriteLine("Prosjek je {0}.", Prosjek(broj));
                    }
                    else
                    {
                        Console.WriteLine("Neispravan unos!");
                    }
                    
                }
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
                Console.ReadLine();
            }

        }

        static string Prosjek(double broj)
        {
            string prosjek = "";

            if (broj < 2)
            {
                prosjek = "nedovoljan";
            }
            else if(broj < 3.5)
            {
                prosjek = "dobar";
            }else if(broj < 4.5)
            {
                prosjek = "vrlo dobar";
            }
            else
            {
                prosjek = "odličan";
            }

            return prosjek;
        }
    }
}
