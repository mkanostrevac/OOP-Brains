using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_2
{
    class Zena : Osoba
    {
        private string devojackoPrezime;

        public Zena(string ime, string prezime, string devojackoPrezime, int starost)
            : base(ime, prezime, starost)
        {
            this.devojackoPrezime = devojackoPrezime;
        }

        public string DevojackoPrezime
        {
            get { return devojackoPrezime; }
            set { devojackoPrezime = value; }
        }

        public override void PredstaviSe()
        {
            Console.WriteLine(String.Format(
                "Ime: {0}, Prezime: {1}, Devojacko prezime: {2}",
                Ime, Prezime, DevojackoPrezime
            ));
        }
    }
}
