using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._7dodaj_broj2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            
                if (broj % 4 == 0 && broj >= 100)
                {
                    Console.Write("Broj je dobar.");
                }
                else
                {
                    Console.Write("Broj nije dobar.");
                }
               
            }catch(Exception e)
            {
                Console.Write("greška: " + e);
            }
            Console.ReadKey();
        }
    }
}
