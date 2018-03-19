using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_3
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

        public string Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        public string Tip
        {
            get { return tip; }
        }

        public abstract double RacunajPovrsinu();

        public abstract double RacunajObim();

        public void StampajPodatke()
        {
            Console.WriteLine(
                Boja + " " +
                Tip + " " +
                RacunajPovrsinu() + " " +
                RacunajObim()
            );
        }
    }
}
