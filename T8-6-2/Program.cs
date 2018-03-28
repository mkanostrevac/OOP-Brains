using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            FabrikaOblika fabrikaOblika = new FabrikaOblika();

            IFigura oblik1 = fabrikaOblika.PribaviOblik("krug");
            oblik1.Crtaj();

            IFigura oblik2 = fabrikaOblika.PribaviOblik("pravougaonik");
            oblik2.Crtaj();

            IFigura oblik3 = fabrikaOblika.PribaviOblik("kvadrat");
            oblik3.Crtaj();

            Console.ReadKey();
        }
    }
}
