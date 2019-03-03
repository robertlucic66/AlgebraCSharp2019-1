using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10.savrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.10 Savršen broj
            // Napišite program koji ispisuje je li uneseni broj savršen ili ne. 
            Console.Write("Unesite prirodan broj: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj <= 0)
                {
                    throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                }

                int zbrojDjelitelja = 0;

                for (int i = 1; i < broj; i++)
                {
                    if (broj % i == 0)
                    {
                        zbrojDjelitelja += i;
                    }
                }

                if (broj == zbrojDjelitelja)
                {
                    Console.WriteLine("Unešeni broj je savršen.");
                }
                else
                {
                    Console.WriteLine("Unešeni broj nije savršen.");
                }
            }
            catch (PrirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch(Exception e)
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


