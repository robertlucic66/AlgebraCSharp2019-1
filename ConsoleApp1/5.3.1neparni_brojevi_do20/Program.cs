using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1neparni_brojevi_do20
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 20; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
