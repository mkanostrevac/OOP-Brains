using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Petar", "Petrovic", 35);
            Osoba o2 = new Osoba("Ivana", "Ivanovic", 32);

            // Vozilo v = new Vozilo("Opel", "Corsa", "NS021IT", 2004, o1);
            Automobil a = new Automobil("Opel", "Corsa", "NS021IT", 2004, o1, new Motor(false, "petrol", 70, 1400), 5);
            Kamion k = new Kamion("Volvo", "FH", "NS021RS", 2016, o1, new Motor(false, "dizel", 300, 4000), 3);
            Motocikl m = new Motocikl("Honda", "Rebel", "ZA018RS", 1998, o1, new Motor(false, "petrol", 12, 234), false);

            //v.stampajPodatke();
            a.StampajPodatke();
            k.StampajPodatke();
            m.StampajPodatke();

            a.PrenosVlasnistva(o2);
            k.PrenosVlasnistva(o2);
            m.PrenosVlasnistva(o2);

            a.StampajPodatke();
            k.StampajPodatke();
            m.StampajPodatke();

            Console.Read();

            Console.Read();
        }
    }
}
