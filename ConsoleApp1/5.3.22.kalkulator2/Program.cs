using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._22.kalkulator2
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            // Kalkulator 2
            /* Dopunite program - kalkulator tako da se nakon izračuna ispiše poruka:
             * "Želite li računati ponovno (D/N)" i sve dok je odgovor potvrdan,
             * ponovno se traži unos dva broja i računske operacije. */
            double a = 0, b = 0;
            string operacija = "";
            string odgovor = "D";

            while(odgovor == "D" || odgovor == "d"){
                try
                {
                    Console.Write("Unesite 1. prirodan broj: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Unesite 2. prirodan broj: ");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Unesite operaciju + - * / ");
                    operacija = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("greška 1. " + ex.ToString());
                }
                finally
                { }

                switch (operacija)
                {
                    case "+":
                    case "plus":
                        Console.WriteLine("Zbroj je {0} + {1} = {2}", a, b, (a + b));
                        break;
                    case "-":
                        Console.WriteLine("Razlika je {0} - {1} = {2}", a, b, (a - b));
                        break;
                    case "*":
                    case "x":
                        Console.WriteLine("Umnožak je {0} * {1} = {2}", a, b, (a * b));
                        break;
                    default:
                        try
                        {
                            //DivideByZeroException
                            Console.WriteLine("Kvocijent je {0} / {1} = {2}", a, b, SafeDivision(a, b));
                        }
                        catch (DivideByZeroException dbzex)
                        {
                            Console.WriteLine("Ne možemo djelito s nulom. drugi parametar je 0. " + dbzex.ToString());
                        }
                        catch (Exception ex2)
                        {
                            Console.WriteLine("greška 2. " + ex2.ToString());
                        }

                        break;
                }
                Console.Write("Želite li računati ponovno (D/N)");
                odgovor = Console.ReadLine();
            }
        }
    }
}
