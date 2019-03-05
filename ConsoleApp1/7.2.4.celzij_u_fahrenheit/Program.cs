using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4.celzij_u_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite stupnjeve Celzijuse: ");
            try
            {
                double celzijus = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} C = {1} F", celzijus, CtoF(celzijus));
            }catch(FormatException fex)
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

        static double CtoF (double celzijus)
        {
            return (double)9 / 5 * celzijus + 32;
        }
    }
}
