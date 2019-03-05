using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4.zbirka.znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());

                ArrayList arr = new ArrayList();
                while (broj > 0)
                {
                    arr.Add(broj % 10);
                    broj /= 10;
                }

                Console.WriteLine("Ispis znamenki naopako: ");
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(PrirodanBrojException pex)
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

