using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._6.prost_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj <= 0)
                {
                    throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                }

                if (Prost(broj))
                {
                    Console.WriteLine("Prost broj.");
                }
                else
                {
                    Console.WriteLine("Složen broj.");
                }
            }
            catch(PrirodanBrojException pex)
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

        static bool Prost(int broj)
        {
            bool prost = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
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

