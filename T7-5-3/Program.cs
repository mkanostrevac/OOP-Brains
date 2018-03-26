using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bojler bojler = new Bojler();
            UpravljanjeBojlerom upravljanjeBojlerom = new UpravljanjeBojlerom(bojler);
            SnimacPodataka snimac = new SnimacPodataka("zapisnikStanjaBojlera.txt");

            // subscribers
            upravljanjeBojlerom.stanjeBojleraPromenjeno += new SnimacPromeneStanjaBojlera(IspisiPorukuNaKonzolu);
            upravljanjeBojlerom.stanjeBojleraPromenjeno += new SnimacPromeneStanjaBojlera(snimac.ZapisiPorukuUFajl);

            upravljanjeBojlerom.PromeniStanjeBojlera(31, 17);
            upravljanjeBojlerom.PromeniStanjeBojlera(31, 33);
            upravljanjeBojlerom.PromeniStanjeBojlera(31, 55);
            upravljanjeBojlerom.PromeniStanjeBojlera(31, 20);

            Console.ReadKey();
        }

        static void IspisiPorukuNaKonzolu(string poruka)
        {
            Console.WriteLine(poruka);
        }
    }
}
