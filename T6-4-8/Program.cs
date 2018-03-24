using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kompanije =    
            {
                "1,Apple,20.123,true",
                "2,Google,15.123,true",
                "3,Microsoft,18.123,true",
                "4,Volvo,20.12,false",
                "5,BMW,12.22,false"
            };

            foreach (var kompanija in kompanije)
            {
                string[] podaci = kompanija.Split(',');
                int redniBroj = int.Parse(podaci[0]);
                string naziv = podaci[1];
                double vrednost = double.Parse(podaci[2], CultureInfo.InvariantCulture);
                bool itKompanija = bool.Parse(podaci[3]);

                Console.WriteLine("{0}: Kompanija {1} vredi {2} milijardi dolara. Da li je to IT kompanije? {3}",
                    redniBroj, naziv, vrednost, itKompanija);
            }

            Console.ReadKey();
        }
    }
}
