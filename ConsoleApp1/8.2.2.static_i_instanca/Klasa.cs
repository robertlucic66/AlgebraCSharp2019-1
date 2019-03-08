using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2.static_i_instanca
{
    class Klasa
    {
        // static funkcija koja vraća je li broj prost ili složen

        public static bool ProstSlozen(int broj)
        {
            bool prostBroj = true;
            for(int i = 2; i <broj; i++){
                if (broj % i == 0)
                {
                    prostBroj = false;
                    break;
                }
            }

            return prostBroj;
        }

        // Metoda instance

        public bool Savrsen(int broj)
        {
            int zbrojDjelitelja = 0;

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    zbrojDjelitelja += i;
                }
            }

            if ( broj == zbrojDjelitelja)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
