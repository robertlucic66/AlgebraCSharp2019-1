using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._8.obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite faktorijel: ");
            try
            {
                int faktorijel = int.Parse(Console.ReadLine());
                if (faktorijel <= 0)
                {
                    throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                }

                Console.WriteLine("{0} = {1}!", faktorijel, Prirodan(faktorijel));
            }
            catch (PrirodanBrojException pex)
            {
                Console.WriteLine("Greška. Poruka: " + pex.ToString());
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

        static int Prirodan(int faktorijel)
        {
  
                return faktorijel / Prirodan(faktorijel -1);
            
        }
    }
}



public class PrirodanBrojException : Exception
{
    public PrirodanBrojException()
    {
    }

    public PrirodanBrojException(string message) : base(message)
    {
    }

    public PrirodanBrojException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

