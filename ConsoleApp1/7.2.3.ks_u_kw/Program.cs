using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3.ks_u_kw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite snagu u KS (konjske snage): ");
            try
            {
                double ks = double.Parse(Console.ReadLine());
                if (ks <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVAN BROJ!");
                }

                Console.WriteLine("Snaga izražena u kilovatima je: " + KStoKW(ks));
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

        static double KStoKW(double ks)
        {
            return ks * 0.736;
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


