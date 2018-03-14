using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Vozilo
    {
        protected string marka;
        protected string tip;
        protected string registracija;
        protected int godiste;
        protected Osoba vlasnik;
        protected Motor pogonskiAgregat;

        protected Vozilo(string marka, string tip, string registracija, int godiste, Osoba vlasnik, Motor pogonskiAgregat)
        {
            this.marka = marka;
            this.tip = tip;
            this.registracija = registracija;
            this.godiste = godiste;
            this.vlasnik = vlasnik;
            this.pogonskiAgregat = pogonskiAgregat;
        }

        public string PribaviMarku()
        {
            return marka;
        }

        public string PribaviTip()
        {
            return tip;
        }

        public string PribaviRegistraciju()
        {
            return registracija;
        }

        public int PribaviGodiste()
        {
            return godiste;
        }

        public void PrenosVlasnistva(Osoba noviVlasnik)
        {
            vlasnik = noviVlasnik;
        }

        protected Motor PribaviPogonskiAgregat()
        {
            return pogonskiAgregat;
        }

        protected void StampajPodatke()
        {
            Console.WriteLine(
                PribaviMarku() + " " +
                PribaviTip() + " " +
                PribaviGodiste() + " " +
                PribaviRegistraciju() + " " +
                vlasnik.PribaviIme() + " " +
                vlasnik.PribaviPrezime()
            );
        }

    }
}
