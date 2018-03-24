using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite Vas JMBG:");
            string jmbg = Console.ReadLine();

            Console.WriteLine("Unesite Vase Ime:");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite Vasu platu:");
            double plata = 0;
            double.TryParse(Console.ReadLine(), out plata);

            Console.WriteLine("JMBG: {0}, Ime: {1}, Plata: {2}", jmbg, ime, plata);

            Console.ReadKey();
        }
    }
}
