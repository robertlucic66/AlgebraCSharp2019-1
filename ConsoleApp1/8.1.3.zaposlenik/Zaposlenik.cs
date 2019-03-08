using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.zaposlenik
{
    class Zaposlenik
    {

        // Svojstva

        public string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string jmbg = "";
        public string JMBG
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public double brojBodova;
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }
                else
                {
                    Exception ex = new Exception("Morate unijeti pozitivnu brojčanu vrijednost!");
                    throw ex;
                }
            }
        }

        public double vrijednostBoda;
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set
            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Morate unijeti pozitivnu brojčanu vrijednost!");
                    throw ex;
                }
            }
        }

        // ReadOnly
        public double Porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return neto * 0.06;
                }else if (neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }
            }
        }

        // Metode

        public double NetoIzracunPlace()
        {
            return this.BrojBodova + this.VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }



        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;
        }

    }
}
