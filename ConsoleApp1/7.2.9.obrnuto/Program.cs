using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._9.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.Write("Unesite ocjenu slovima: ");
                    string ocjena = Console.ReadLine();
                    Console.WriteLine(Ocjena(ocjena));                              
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

        static string Ocjena(string ocjena)
        {

            
                if (ocjena == "Nedovoljan" || ocjena == "nedovoljan")
                {
                   
                    return "1";
                }
                else if (ocjena == "Dovoljan" || ocjena == "dovoljan")
                {                    
                    return "2";
                }
                else if (ocjena == "Dobar" || ocjena == "dobar")
                {
                    return "3";
                }
                else if (ocjena == "Vrlo dobar" || ocjena == "vrlo dobar")
                {
                    return "4";
                }
                else if (ocjena == "Odličan" || ocjena == "odličan")
                {
                    return "5";
                }
                else
                {
                    return "Pogrešan unos!";
                }
            
        }
    }
}
