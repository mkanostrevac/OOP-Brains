using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_1
{
    class Osoba : IComparable<Osoba>
    {
        private string ime;
        private string prezime;
        private string jmbg;

        public Osoba(string ime, string prezime, string jmbg)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public int CompareTo(Osoba drugaOsoba)
        {
            int uporedjivanjeImena = this.Ime.CompareTo(drugaOsoba.Ime);

            if (uporedjivanjeImena != 0)
            {
                return uporedjivanjeImena;
            }
            else
            {
                int uporedjivanjePrezimena = this.Prezime.CompareTo(drugaOsoba.Prezime);

                if (uporedjivanjePrezimena != 0)
                {
                    return uporedjivanjePrezimena;
                }
                else
                {
                    return this.Jmbg.CompareTo(drugaOsoba.Jmbg);
                }
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Ime: {0}, Prezime: {1}, Jmbg: {2}",
                Ime, Prezime, Jmbg
            );
        }
    }
}
