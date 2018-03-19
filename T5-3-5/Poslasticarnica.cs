using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_5
{
    class Poslasticarnica : Prodavnica, IImenovanje
    {
        private string ime;

        private string[] meni = {
            "Sladoled",
            "Torta",
            "Krofna",
            "Kafa",
            "Caj",
            "Limunada"
        };

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public override string[] PogledajPonudu()
        {
            return meni;
        }

        public override void Kupi(string artikal)
        {
            Console.WriteLine("Upravo ste narucili " + artikal);
        }
    }
}
