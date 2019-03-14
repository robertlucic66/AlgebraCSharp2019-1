using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._6.palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite liniju teksta: ");
            string tekst = Console.ReadLine();

            tekst = tekst.Replace(" ", "");

            string obrnuto = "";
            for(int i = tekst.Length -1; i > 0; i--)
            {
                obrnuto += tekst[i];
            }

            if (tekst == obrnuto)
            {
                Console.WriteLine("To je palindrom!");
            }
            else
            {
                Console.WriteLine("To nije palindrom!");
            }
            Console.ReadKey();

        }
    }
}
