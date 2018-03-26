using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_3
{
    public class Bojler
    {
        private double zeljenaTemperatura;
        private double trenutnaTemperatura;
        private bool termostat;

        public double ZeljenaTemperatura
        {
            get { return zeljenaTemperatura; }
            set { zeljenaTemperatura = value; }
        }

        public double TrenutnaTemperatura
        {
            get { return trenutnaTemperatura; }

            set
            {
                trenutnaTemperatura = value;

                if (trenutnaTemperatura < zeljenaTemperatura)
                    termostat = true;
                else
                    termostat = false;
            }
        }

        public override string ToString()
        {
            return string.Format("\n Bojler: \n\t Zeljena T: {0} \n\t Trenutna T: {1} \n\t Termostat: {2}", 
                zeljenaTemperatura, trenutnaTemperatura, termostat ? "ON" : "OFF");
        }
    }
}
