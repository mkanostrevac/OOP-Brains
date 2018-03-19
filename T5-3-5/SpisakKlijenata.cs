using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_5
{
    class SpisakKlijenata
    {
        private string[] ime;
        private int trenutniBrojKlijenata;
        private int maxBrojKlijenata;

        public SpisakKlijenata(int maxBrojKlijenata)
        {
            this.maxBrojKlijenata = maxBrojKlijenata;
            this.trenutniBrojKlijenata = 0;
            this.ime = new string[maxBrojKlijenata];
        }

        public string NadjiKlijenta(string ime)
        {
            for (int i = 0; i < this.trenutniBrojKlijenata; i++)
            {
                if (this.ime[i].Equals(ime))
                {
                    return this.ime[i];
                }
            }

            return "Klijent nije pronadjen";
        }

        public void DodajKlijenta(string ime)
        {
            if (this.trenutniBrojKlijenata < this.maxBrojKlijenata)
            {
                this.ime[this.trenutniBrojKlijenata++] = ime;
            }
            else
            {
                Console.WriteLine("Nema vise mesta u spisku klijenata!");
            }
        }
    }
}
