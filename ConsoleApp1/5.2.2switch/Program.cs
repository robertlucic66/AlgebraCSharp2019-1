using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2switch
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";

            Console.Write("Unesite 1. broj: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Unesite 2. broj: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Unesite računsku operaciju (+, -, *, /): ");
            operacija = Console.ReadLine();

            switch(operacija)
            {
                case "+":
                case "plus":
                    Console.WriteLine("Zbroj je: {0}", a + b);
                    break;
                case "-":
                    Console.WriteLine("Razlika je: {0}", a - b);
                    break;
                case "*":
                case "x":
                    Console.WriteLine("Umnožak je: {0}", a * b);
                    break;
                default:
                    Console.WriteLine("Kvocijent je: {0}", a / b);
                    break;
            }

            Console.WriteLine("Pritisnite neku tipku za kraj");
            Console.ReadKey();
        }
    }
}
