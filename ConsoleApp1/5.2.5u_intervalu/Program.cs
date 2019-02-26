using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._5u_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj >= 100 && broj <= 200)
            {
                Console.Write("Broj je u intervalu [100, 200]");
            }
            else
            {
                Console.Write("Broj nije u intervalu [100, 200]");
            }
            Console.ReadKey();

        }
    }
}
