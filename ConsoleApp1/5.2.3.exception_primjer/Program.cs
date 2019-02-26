using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3.exception_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite broj: ");
                int a;
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unešen je broj {0}", a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Dogodila se greška u programu!");
                Console.WriteLine("Opis greške: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Pritisnite neku tipku za kraj...");
                Console.ReadKey();
            }
        }
    }
}
