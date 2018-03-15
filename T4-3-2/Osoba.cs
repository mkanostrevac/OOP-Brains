using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_2
{
    class Osoba
    {
        private string ime;
        private string prezime;
        private int starost;

        public Osoba(string ime, string prezime, int starost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.starost = starost;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public int Starost
        {
            get
            {
                return starost;
            }

            set
            {
                starost = value;
            }
        }

        public virtual void PredstaviSe()
        {
            Console.WriteLine(String.Format(
                "Ime: {0}, Prezime: {1}, Starost: {2} godina",
                Ime, Prezime, Starost
            ));
        }
    }
}
