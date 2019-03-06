using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fahrenheit u Celzijus

            Console.Write("Unesite stupnjeve u F: ");
            try
            {
                double fahrenheit = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} F = {1} C", fahrenheit, FtoC(fahrenheit));
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Greška. Poruka: " + fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }


        }

        static double FtoC(double fahrenheit)
        {
            return (double)(fahrenheit -32) / 1.8;
        }
    }
}
