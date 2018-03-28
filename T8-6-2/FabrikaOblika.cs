using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_6_2
{
    class FabrikaOblika
    {
        public IFigura PribaviOblik(string tipOblika)
        {
            switch (tipOblika)
            {
                case "krug":
                    return new Krug();
                case "pravougaonik":
                    return new Pravougaonik();
                case "kvadrat":
                    return new Kvadrat();
                default:
                    return null;
            }
        }
    }
}
