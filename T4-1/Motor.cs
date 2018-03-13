using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Motor
    {
        private bool radi;      //pokrenut ili ne
        private string tip;     //dizel ili benzin
        private int snaga;      //snaga u kW
        private int kubikaza;   //kubikaza u ccm

        public Motor(bool radi, string tip, int snaga, int kubikaza)
        {
            this.radi = radi;
            this.tip = tip;
            this.snaga = snaga;
            this.kubikaza = kubikaza;
        }

        public bool Radi
        {
            get { return this.radi; }
            set { this.radi = value; }
        }

        public string Tip
        {
            get { return this.tip; }
        }

        public int Snaga
        {
            get { return this.snaga; }
        }

        public int Kubikaza
        {
            get { return this.kubikaza; }
        }

        public void Ukljuci()
        {
            Radi = true;
        }

        public void Iskljuci()
        {
            Radi = false;
        }

        public void StampajPodatke()
        {
            Console.WriteLine("Informacije o motoru:");
            Console.WriteLine("Ukljucen: " + Radi +
                " Tip: " + Tip +
                " Snaga: " + Snaga +
                " Kubikaza: " + Kubikaza);
        }
    }
}
