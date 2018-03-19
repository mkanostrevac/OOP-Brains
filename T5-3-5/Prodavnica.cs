using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_5
{
    abstract class Prodavnica
    {
        private SpisakKlijenata spisakKlijenata;

        public void IzracunajPDV()
        {
            Console.WriteLine("Stopa PDV-a je 20%!");
        }

        public abstract string[] PogledajPonudu();
        public abstract void Kupi(string artikal);
    }
}
