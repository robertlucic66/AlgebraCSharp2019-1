using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite snagu u kilovatima: ");
            try
            {
                double kw = double.Parse(Console.ReadLine());
                if (kw <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVAN BROJ!");
                }

                Console.WriteLine("Snaga izražena u KS je: " + KWtoKS(kw));
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

        static double KWtoKS(double kw)
        {
            return kw / 0.736;
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

