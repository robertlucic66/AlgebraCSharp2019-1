using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3.zbirka.sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();
            Console.WriteLine("Unesite elemente niza: ");
            try
            {
                while (broj != 0)
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj < 0)
                    {
                        throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                    }
                    arr.Add(broj);

                }
                arr.Sort();
                Console.WriteLine("Ispis brojeva iz niza: ");
                foreach (int a in arr)
                {
                    Console.WriteLine(a);
                }
            }
            catch (PrirodanBrojException pex)
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

