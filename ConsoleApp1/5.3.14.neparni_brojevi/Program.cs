using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._14.neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.14 Neparni brojevi
            // Napišite program koji ispisuje sve neparne brojeve iz intervala [1, 10]
            Console.Write("Neparni brojevi iz intervala [1, 10] su: ");
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write("{0}, ", i.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
