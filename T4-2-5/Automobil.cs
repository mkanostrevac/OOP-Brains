using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Automobil : Vozilo
    {
        private int brojVrata;

        public Automobil(string marka, string tip, string registracija, int godiste, Osoba vlasnik, Motor pogonskiAgregat, int brojVrata)
            : base(marka, tip, registracija, godiste, vlasnik, pogonskiAgregat)
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

            PribaviPogonskiAgregat().StampajPodatke();
        }
    }
}
