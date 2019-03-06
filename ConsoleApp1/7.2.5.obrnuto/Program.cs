using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._5.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program ispisuje y koordinatu točke P2 (y2).

            try
            {
                Console.Write("Unesite x koordinatu točke P1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Unesite y koordinatu točke P1: ");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("Unesite x koordinatu točke P2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Unesite udaljenost: ");
                double d = double.Parse(Console.ReadLine());

                Console.WriteLine("y2 = {0}", y2(x1, y1, x2, d));
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

        static double y2(double x1, double y1, double x2, double d)
        {
            return d - (x2 -x1) + y1;
        }
    }
}
