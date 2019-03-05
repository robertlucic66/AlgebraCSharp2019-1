using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1.krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite radijus: ");
            try
            {
                double radijus = double.Parse(Console.ReadLine());
                if (radijus <= 0)
                {
                    throw new PozitivanBrojException("UNESITE POZITIVAN BROJ!");
                }
                Console.WriteLine("Opseg kruga je: " + opsegKruga(radijus));
                Console.WriteLine("Površina kruga je: " + povrsinaKruga(radijus));
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

        static double opsegKruga (double radijus)
        {
            return 2 * radijus * Math.PI;
        }

        static double povrsinaKruga (double radijus)
        {
            return (radijus * radijus) * Math.PI;
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
