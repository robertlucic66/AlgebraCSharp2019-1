using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1._1pozitivan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan");
            }
            else
            {
                if(broj == 0)
                {
                    Console.WriteLine("Broj je jednak nuli");
                }
                else
                {
                    Console.WriteLine("Broj je negativan");
                }
            }
            Console.ReadKey();
        }
    }
}
