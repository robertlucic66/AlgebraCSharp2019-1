using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaNagradna
{
    class Ucenik
    {

        // Polja

        private string ime;
        private string prezime;
        private string oib;
        public string telefon;
        private double racun;
        Random r = new Random();

        // Svojstva

        public string Ime
        {
            get => ime;
        }

        public string Prezime
        {
            get => prezime;
        }

        public string Oib
        {
            set => oib = value;
        }
        public double Racun
        {
            get => racun;
            set => racun = value;
        }

        // Metode

        public override string ToString()
        {
            return "Pozdrav, " + this.ime + " " + this.prezime + ". Stanje računa: " + this.racun.ToString();
        }

        // Konstruktori

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
     
            this.racun = r.Next(2000, 6000);                         
        }

        public Ucenik(string ime, string prezime, string oib) : this(ime, prezime)
        {
            this.oib = oib;

            this.racun = r.Next(2000, 6000);
        }

        public Ucenik(string ime, string prezime, string oib, double racun) : this(ime, prezime, oib)
        {
            this.racun = racun;
        }

    }
}
