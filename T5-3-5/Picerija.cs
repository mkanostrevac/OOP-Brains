using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_5
{
    class Picerija : Prodavnica, IImenovanje
    {
        private string ime;

        private string[] hranaIPice =
        {
            "Pica",
            "Pasta",
            "Salata",
            "Kalcona",
            "Sok",
            "Pivo"
        };

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public override string[] PogledajPonudu()
        {
            return hranaIPice;
        }

        public override void Kupi(string artikal)
        {
            Console.WriteLine("Upravo ste narucili " + artikal);
        }
    }
}
