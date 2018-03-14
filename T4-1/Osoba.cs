using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Osoba
    {
        protected string ime;
        protected string prezime;
        protected int starost;

        public Osoba(string ime, string prezime, int starost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.starost = starost;
        }

        public string PribaviIme()
        {
            return ime;
        }

        public string PribaviPrezime()
        {
            return prezime;
        }

        public int PribaviStarost()
        {
            return starost;
        }

        public void PredstaviSe()
        {
            Console.WriteLine(String.Format(
                "Ime: {0}, Prezime: {1}, Starost: {2} godina",
                PribaviIme(), PribaviPrezime(), PribaviStarost()
            ));
        }
    }
}
