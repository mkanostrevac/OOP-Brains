using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_1
{
    class Kvadrat : Oblik
    {
        private double stranica;

        public Kvadrat(string boja, double stranica)
            : base(boja, "Kvadrat")
        {
            this.stranica = stranica;
        }

        public override double RacunajPovrsinu()
        {
            return stranica * stranica;
        }

        public override double RacunajObim()
        {
            return 4 * stranica;
        }
    }
}
