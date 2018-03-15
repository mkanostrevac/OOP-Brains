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

        public void PostaviRadi(bool radi)
        {
            this.radi = radi;
        }

        public bool PribaviRadi()
        {
            return radi;
        }

        public string PribaviTip()
        {
            return tip;
        }

        public int PribaviSnagu()
        {
            return snaga;
        }

        public int PribaviKubikazu()
        {
            return kubikaza;
        }

        public void Ukljuci()
        {
            PostaviRadi(true);
        }

        public void Iskljuci()
        {
            PostaviRadi(false);
        }

        public void StampajPodatke()
        {
            Console.WriteLine("Informacije o motoru:");
            Console.WriteLine(
                "Ukljucen:" + PribaviRadi() +
                " Tip: " + PribaviTip() +
                " Snaga: " + PribaviSnagu() +
                " Kubikaza: " + PribaviKubikazu()
            );
        }
    }
}
