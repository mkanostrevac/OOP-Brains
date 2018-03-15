using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_1
{
    abstract class Oblik
    {
        private string boja;
        private string tip;

        public Oblik(string boja, string tip)
        {
            this.boja = boja;
            this.tip = tip;
        }

        public void PostaviBoju(string boja)
        {
            this.boja = boja;
        }

        public string PribaviBoju()
        {
            return boja;
        }

        public string PribaviTip()
        {
            return tip;
        }

        public abstract double RacunajObim();

        public abstract double RacunajPovrsinu();

        public void StampajPodatke()
        {
            Console.WriteLine(
                PribaviBoju() + " " +
                PribaviTip() + " " +
                RacunajPovrsinu() + " " +
                RacunajObim()
            );
        }
    }
}
