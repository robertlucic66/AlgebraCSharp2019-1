using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._6dodaj_broj1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Unesite cijeli broj: ");
                int broj = int.Parse(Console.ReadLine());
                if (broj % 3 == 0 || broj % 5 == 0)
                {
                Console.Write("Broj je dobar.");
                }
                else
                {
                Console.Write("Broj nije dobar.");
                }
            Console.ReadKey();
        }
    }
}
