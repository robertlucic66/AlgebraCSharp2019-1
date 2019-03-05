using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2.potprogrami
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Program.HelloWorld();
            Console.WriteLine(HelloWorld("Ola"));
            Console.ReadKey();


        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello world");
        }
        static String HelloWorld(String poz)
        {
            return poz + " i tebi putniče";
        }

    }
}
