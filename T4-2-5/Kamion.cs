using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Kamion : Vozilo
    {
        private int brojOsovina;

        public Kamion(string marka, string tip, string registracija, int godiste, Osoba vlasnik, Motor pogonskiAgregat, int brojOsovina)
            : base(marka, tip, registracija, godiste, vlasnik, pogonskiAgregat)
        {
            this.brojOsovina = brojOsovina;
        }

        public int PribaviBrojOsovina()
        {
            return brojOsovina;
        }

        public void StampajPodatke()
        {
            Console.WriteLine(
                PribaviMarku() + " " +
                PribaviTip() + " " +
                PribaviGodiste() + " " +
                PribaviRegistraciju() + " " +
                PribaviBrojOsovina() + " " +
                vlasnik.PribaviIme() + " " +
                vlasnik.PribaviPrezime()
            );

            PribaviPogonskiAgregat().StampajPodatke();
        }
    }
}
