

using System;

namespace _8._1._2_prirucnik
{
    public abstract class Osoba
    {
        public string ime = "";
        public string prezime = "";
        public DateTime datumNastanka;
        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("pozvana metoda Osoba:Osoba()");
            
        }

        public string Ime
        {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }





    }
}