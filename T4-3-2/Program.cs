using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Marko", "Markovic", 32);
            Osoba osoba2 = new Zena("Ivana", "Ivanovic", "Petrovic", 32);

            osoba1.PredstaviSe();
            osoba2.PredstaviSe();

            Console.ReadKey();
        }
    }
}
