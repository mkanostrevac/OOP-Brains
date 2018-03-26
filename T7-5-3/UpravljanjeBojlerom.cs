using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_3
{
    public delegate void SnimacPromeneStanjaBojlera(string poruka);

    class UpravljanjeBojlerom
    {
        private Bojler bojler;
        private double maksimalnaTolerancija;
        public event SnimacPromeneStanjaBojlera stanjeBojleraPromenjeno;  //publisher (broadcaster)

        public UpravljanjeBojlerom(Bojler bojler)
        {
            this.bojler = bojler;
            this.maksimalnaTolerancija = 10;
        }

        public void PromeniStanjeBojlera(double zeljenaTemperatura, double trenutnaTemperatura)
        {
            bojler.ZeljenaTemperatura = zeljenaTemperatura;
            bojler.TrenutnaTemperatura = trenutnaTemperatura;

            string poruka = "O.K";

            if (bojler.TrenutnaTemperatura > bojler.ZeljenaTemperatura + maksimalnaTolerancija)
            {
                poruka = "Bojler je pregrejan!";
            }

            stanjeBojleraPromenjeno.Invoke(bojler + "\t\t" + poruka);
        }
    }
}
