using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis svih brojeva od 0,1,2 ... 99");
            //Ispis svih brojeva od 0,1,2 ... 99
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("");

            Console.WriteLine("\n\nIspis svih brojeva od 16,18,20 ... 88");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva od 135,130,125 ... 55");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("Ispis svih brojeva od 0 do 99 osim 80");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }

            Console.WriteLine("Ispis svih brojeva od 0 do 99 break na 80");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }

            Console.WriteLine("Ispis svih brojeva od 1 do 9999 koji su dijeljivi sa 17");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 1; i < 1000; i++)
            {
                if (i % 17 == 0)
                {
                    Console.Write("{0} ", i);
                }
                
            }

            Console.WriteLine("\n\nIspis svih brojeva od 135,130,125 ... 55");
            //Ispis svih brojeva od 16,18,20 ... 88
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();

        }
    }
}
