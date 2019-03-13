using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1.prirucnik
{
    class Pilot : Vozac
    {
        public Pilot(string v1, string v2) : base(v1, v2)
        {
        }

        public bool Kategorija_x { get; internal set; }

        public override string ToString()
        {
            if (this.Kategorija_x)
            {
                return base.ToString() + " X";
            }

            else
            {
                return base.ToString();
            }
        }
    }
}
