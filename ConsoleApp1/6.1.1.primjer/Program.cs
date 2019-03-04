using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1.primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija
            int[] niz = new int[3];

            // init
            niz[0] = 55;
            niz[2] = 77;
            niz[1] = 22;
            try
            {
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] == null)
                    {
                        throw new Exception("niz sadrži ne inicijaliziranu vrijednost na indexu " + i);
                    }
                    Console.WriteLine((i + 1) + ": " + niz[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
