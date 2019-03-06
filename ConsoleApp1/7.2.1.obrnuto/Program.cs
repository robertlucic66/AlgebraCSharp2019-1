using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program ispisuje radijus kruga za uneseni opseg ili površinu kruga.
                      
            bool unosObavljen = false;

            try
            {
                while (!unosObavljen)
                {
                    Console.WriteLine("Izaberite opseg ili površinu (O/P): ");
                    char odgovor = Console.ReadKey().KeyChar;
                    if (odgovor == 'O' || odgovor == 'o')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unesite opseg kruga: ");
                        double opsegKruga = double.Parse(Console.ReadLine());
                        Console.WriteLine("Radijus kruga je: {0}.", radijusOpseg(opsegKruga));
                        unosObavljen = true;
                    }
                    else if (odgovor == 'P' || odgovor == 'p')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unesite površinu kruga: ");
                        double povrsinaKruga = double.Parse(Console.ReadLine());
                        Console.WriteLine("Radijus kruga je: {0}.", radijusPovrsina(povrsinaKruga));
                        unosObavljen = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pogrešan unos!");
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
                Console.ReadKey();
            }
        }

        static double radijusOpseg(double opsegKruga)
        {
            return opsegKruga / (2 * Math.PI);
        }

        static double radijusPovrsina(double povrsinaKruga)
        {
            return Math.Sqrt(povrsinaKruga / Math.PI);
        }
    }
}
