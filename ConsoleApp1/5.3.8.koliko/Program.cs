﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8.koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-3 Koliko
            // Napišite program koji ispisuje koliko ima brojeva djeljivih sa 7 i nedjeljivih s 3 u intervalu [1, 1000]
            int koliko = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    koliko++;
                }
            }
            Console.WriteLine("Brojeva djeljivih sa 7, a nedjeljivih s 3 iz intervala [1, 1000] ima {0}", koliko);
            Console.ReadLine();
        }
    }
}
