using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._17.potencije2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.17 Potencije 2
            // Napišite program koji ispisuje od 1. do 10.potencije broja 2.
            int potencija;

            for (int i = 1; i <= 10; i++)
            {
                potencija = 1;

                for (int j = 1; j <= i; j++)
                {
                    potencija *= 2;
                }

                Console.WriteLine("2 na {0} = {1}", i, potencija);
            }
            Console.ReadLine();
        }
    }
}