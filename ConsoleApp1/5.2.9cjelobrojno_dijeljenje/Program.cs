﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._9cjelobrojno_dijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Unesite broj: ");
            int broj = 0;
            try
            {
                broj = int.Parse(Console.ReadLine());
                if (broj % 2 == 0)
                {
                    Console.WriteLine("Broj je paran");
                }
                if(broj % 3 == 0)
                {
                    Console.WriteLine("Broj je djeljiv sa 3");
                }
                else
                {
                    Console.WriteLine("Broj {0} nije djeljiv sa 3, ostatak je {1}", broj, broj % 3);
                }
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Greška");
            }
            Console.ReadKey();


        }
    }
}
