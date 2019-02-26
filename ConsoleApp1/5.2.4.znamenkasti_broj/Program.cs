using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4.znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                a = -a;
            }
            if (a < 10)
            {
                Console.Write("Uneseni broj je jednoznamenkasti");
            }else if(a<100){
                Console.Write("Uneseni broj je dvoznamenkasti");
            }else if (a < 1000)
            {
                Console.Write("Uneseni broj je troznamenkasti");
            }
            else
            {
                Console.Write("Uneseni broj je višeznamenkasti");
            }
            Console.ReadKey();
        }
    }
}
