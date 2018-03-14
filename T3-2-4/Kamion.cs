using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_2_4
{
    class Kamion : Vozilo
    {
        private int brojOsovina;

        public Kamion(string marka, string tip, string registracija, int godiste, Osoba vlasnik, int brojOsovina)
            : base(marka, tip, registracija, godiste, vlasnik)
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
        }
    }
}
