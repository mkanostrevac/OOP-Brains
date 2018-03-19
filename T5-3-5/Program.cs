using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Poslasticarnica evropa = new Poslasticarnica();
            Picerija ciao = new Picerija();

            evropa.Ime = "Evropa";
            ciao.Ime = "Ciao";

            evropa.Kupi("Sladoled");
            ciao.Kupi("Pica");

            Console.ReadKey();
        }
    }
}
