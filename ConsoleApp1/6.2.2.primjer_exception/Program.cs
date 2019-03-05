﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2.primjer_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();

            Console.WriteLine("Unosimo nekoliko različitih tipova");

            arr.Add(3);
            arr.Add(6);
            arr.Add(9);
            arr.Add("Jedanaest");
            arr.Add(13);

            // ispis
            for (int i = 0; i < arr.Count; i++)
            {
                try
                {
                    Console.WriteLine(int.Parse(arr[i].ToString()));
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Varijabla nije u formatu koji se može pretvoriti u int");
                }
                
            }
            Console.ReadKey();
        }
    }
}
