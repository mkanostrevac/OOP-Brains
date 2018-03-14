using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_2_4
{
    class Automobil : Vozilo
    {
        private int brojVrata;

        public Automobil(string marka, string tip, string registracija, int godiste, Osoba vlasnik, int brojVrata)
            : base(marka, tip, registracija, godiste, vlasnik)
        {
            this.brojVrata = brojVrata;
        }

        public int PribaviBrojVrata()
        {
            return brojVrata;
        }

        public void StampajPodatke()
        {
            Console.WriteLine(
                PribaviMarku() + " " +
                PribaviTip() + " " +
                PribaviGodiste() + " " +
                PribaviRegistraciju() + " " +
                PribaviBrojVrata() + " " +
                vlasnik.PribaviIme() + " " +
                vlasnik.PribaviPrezime()
            );
        }
    }
}
