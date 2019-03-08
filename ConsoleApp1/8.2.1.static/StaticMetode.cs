using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1.staticprimjer
{
    class StaticMetode
    {
        // Konstruktor
        
        private StaticMetode()
        {

        }

        // Static metode

        public static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        public static double Kub(double broj)
        {
            return broj * broj * broj;
        }

        public static double UdaljenostTocaka (double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public static double CelzijFahrenheit (double stupnjevi)
        {
            return ((double)9 / 5) * stupnjevi + 32;
        }
    }
}
