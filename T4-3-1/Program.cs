using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oblik oblik = new Oblik("Zeleni", "Kvadrat");
            //oblik.RacunajPovrsinu();

            Oblik krug = new Krug("Crveni", 3);
            krug.StampajPodatke();

            Oblik kvadrat = new Kvadrat("Plavi", 4);
            kvadrat.StampajPodatke();

            Console.ReadKey();
        }
    }
}
