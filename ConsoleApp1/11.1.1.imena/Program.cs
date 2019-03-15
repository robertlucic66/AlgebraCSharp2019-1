using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._1.imena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();

            bool unesenKraj = false;
            string ime;
            while (!unesenKraj)
            {
                Console.WriteLine("Unesite ime: ");
                ime = Console.ReadLine();
                if(ime.ToLower() == "kraj")
                {
                    unesenKraj = true;
                }
                else
                {
                    imena.Add(ime);
                }

            }

            List<string> imenaSaSlovomA = (from im in imena
                                           where im.ToLower().Contains("a")
                                           select im).ToList();
            Console.WriteLine();
            Console.Write("Imena koja sadrže slovo \"a\" su: ");

            foreach (string item in imenaSaSlovomA)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();
        }
    }
}
