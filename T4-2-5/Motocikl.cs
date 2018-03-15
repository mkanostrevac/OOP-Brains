using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Motocikl : Vozilo
    {
        private bool registrovan;

        public Motocikl(string marka, string tip, string registracija, int godiste, Osoba vlasnik, Motor pogonskiAgregat, bool registrovan)
            : base(marka, tip, registracija, godiste, vlasnik, pogonskiAgregat)
        {
            this.registrovan = registrovan;
        }

        public bool PribaviRegistrovan()
        {
            return registrovan;
        }

        public void StampajPodatke()
        {
            base.StampajPodatke();
            string registrovan = PribaviRegistrovan() ?
                "Registrovan" : "Neregistrovan";
            Console.WriteLine(" " + registrovan);

            PribaviPogonskiAgregat().StampajPodatke();
        }
    }
}
