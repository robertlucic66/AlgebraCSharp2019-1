using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._16.potencije1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.16 Potencije 1
            // Napišite program koji ispisuje sve potencije broja 2 manje od 1000.
            Console.Write("Potencije broja 2 manje od 1000 su: ");
            for (int i = 1; i <= 1000; i *= 2)
            {
                Console.Write("{0}, ", i.ToString());
            }
            Console.ReadLine();
        }
    }
}
