using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2.jednakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite duljinu 1. katete: ");
            try
            {
                double a = double.Parse(Console.ReadLine());
                Console.Write("Unesite duljinu 2. katete: ");
                double b = double.Parse(Console.ReadLine());
                if(a <= 0 || b <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVNE BROJEVE!");
                }

                Console.WriteLine("Površina jednakokračnog trokuta je {0}.", Povrsina(a, b));
            }
            catch(PozitivanBrojException pex)
            {
                Console.WriteLine("Greška. Poruka: " + pex.ToString());
            }
            catch(FormatException fex)
            {
                Console.WriteLine("Greška. Poruka: " + fex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
                Console.ReadLine();
        }

        static double Povrsina(double a, double b)
        {
            return (a * b) / 2;
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

