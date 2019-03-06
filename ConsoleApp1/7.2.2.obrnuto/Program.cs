using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program traži unos površine jednakokračnog trokuta i duljinu jedne katete.
            // Zatim ispisuje duljinu druge katete.

            Console.Write("Unesite površinu jednakokračnog trokuta: ");
            try
            {
                double povrsina = double.Parse(Console.ReadLine());
                Console.Write("Unesite duljinu prve katete: ");
                double a = double.Parse(Console.ReadLine());
                if (povrsina <= 0 || a <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVNE BROJEVE!");
                }

                Console.WriteLine("Duljina druge katete je {0}.", Kateta(a, povrsina));
            }
            catch (PozitivanBrojException pex)
            {
                Console.WriteLine("Greška. Poruka: " + pex.ToString());
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

        static double Kateta(double a, double povrsina)
        {
            return (2 * povrsina) / a;
        }
    }
}

public class PozitivanBrojException : Exception
{
    public PozitivanBrojException()
    {
    }

    public PozitivanBrojException(string message) : base(message)
    {
    }

    public PozitivanBrojException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

