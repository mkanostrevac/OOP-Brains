using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_1
{
    class Krug : Oblik
    {
        private double poluprecnik;

        public Krug(string boja, double poluprecnik)
            : base(boja, "Krug")
        {
            this.poluprecnik = poluprecnik;
        }

        public override double RacunajPovrsinu()
        {
            return Math.Pow(poluprecnik, 2) * Math.PI;
        }

        public override double RacunajObim()
        {
            return 2 * poluprecnik * Math.PI;
        }
    }
}
