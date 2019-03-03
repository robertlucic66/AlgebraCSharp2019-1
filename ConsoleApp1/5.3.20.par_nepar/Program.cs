using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._20.par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.20 Par-nepar
            /* Program koji traži unos prirodnih brojeva dok se ne unese 0, a zatim
             * ispisuje koliko je bilo uneseno parnih, a koliko neparnih
             * (0 na kraju se ne računa ni kao paran ni kao neparan) */
            int brojParnih = 0;
            int brojNeparnih = 0;
            int broj = -1;
            try
            {
                while (broj != 0)
                {
                    Console.Write("Unesite prirodan broj: ");
                    broj = int.Parse(Console.ReadLine());
                    if (broj < 0)
                    {
                        throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                    }
                    if (broj > 0 && broj % 2 == 0)
                    {
                        brojParnih++;
                    }
                    else
                    {
                        brojNeparnih++;
                    }
                }

                Console.WriteLine("Parnih: {0}", brojParnih.ToString());
                Console.WriteLine("Neparnih: {0}", brojNeparnih.ToString());
            }
            catch (PrirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška. Poruka: " + e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

public class PrirodanBrojException : Exception
{
    public PrirodanBrojException()
    {
    }

    public PrirodanBrojException(string message) : base(message)
    {
    }

    public PrirodanBrojException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

