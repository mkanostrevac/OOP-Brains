using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura f1, f2;

            // f1 = new IFigura();
            f1 = new Krug("Crveni", 3);
            f2 = new Kvadrat("Plavi", 4);

            Console.WriteLine(f1.RacunajPovrsinu());
            Console.WriteLine(f1.RacunajObim());

            Console.WriteLine(f2.RacunajPovrsinu());
            Console.WriteLine(f2.RacunajObim());

            var oblik = (Oblik)f1;
            oblik.StampajPodatke();

            Console.ReadKey();
        }
    }
}
