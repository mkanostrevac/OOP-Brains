using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spisak polaznici = new Spisak();

            polaznici.UcitajListuPolaznika(@"D:\ITBrains\spisak.txt");
            polaznici.StampajListuPolaznika();
            Console.ReadKey();

            polaznici.SortirajListuPolaznika();
            polaznici.StampajListuPolaznika();
            Console.ReadKey();

            polaznici.UpisiListuPolaznika("uredjeniSpisak.txt");
        }
    }
}
