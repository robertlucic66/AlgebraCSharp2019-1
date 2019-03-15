using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePrimjerZbirka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite podatak tipa DateTime");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            Console.WriteLine("Vrijeme: ");
            Console.WriteLine(d1.ToShortDateString());

            Console.WriteLine("Dan u tjednu: ");
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            Console.WriteLine("Sad je točno: ");
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString("MMMM dddd yyyy HH:mm:ss fff"));

            DateTime dNG = new DateTime(2019, 1, 1);

            TimeSpan ts = dNG.Subtract(d1);

            Console.WriteLine("Do Nove godine ima: ");
            Console.WriteLine("dana" + ts.Days);
            Console.WriteLine("i sati " + ts.Hours);
            Console.WriteLine(
                "To je ukupno sati " + ts.TotalHours)
                );
            Console.WriteLine("i {0} dana {1})

            

        }
    }
}
