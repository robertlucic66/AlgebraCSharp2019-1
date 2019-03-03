using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._15.ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.15 Ispis unatrag
            // Napišite program koji ispisuje prirodne brojeve iz intervala [1, 10] unatrag.
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
