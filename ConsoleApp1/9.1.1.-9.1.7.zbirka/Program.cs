using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1._9._1._7.zbirka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9.1.1. znak u rijeci");
            string rijec = "Danas je suncan dan";
            char slovo = 'n';

            int brojac = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if(rijec[i] == slovo)
                {
                    brojac++;
                }
            }
            Console.WriteLine("Znak {0} pojavljuje se u rijeci '{1}' {2} puta", slovo, rijec, brojac);
            Console.ReadKey();
        }
    }
}
