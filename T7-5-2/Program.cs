using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_2
{
    public delegate void IzvrsilacOperacija(int n);

    public class Program
    {
        static private int rezultat;

        static void Main(string[] args)
        {
            rezultat = 0;
            IzvrsilacOperacija digitron = new IzvrsilacOperacija(Sabiranje);

            digitron.Invoke(1);
            Console.WriteLine(rezultat);
            digitron.Invoke(2);
            Console.WriteLine(rezultat);
            digitron.Invoke(3);
            Console.WriteLine(rezultat);

            digitron += new IzvrsilacOperacija(Mnozenje);
            digitron.Invoke(2); // izvrsavanje vise operacija u isto vreme (izvrsava se i sabiranje i mnozenje)
            Console.WriteLine(rezultat);

            digitron -= new IzvrsilacOperacija(Mnozenje);
            digitron.Invoke(3);
            Console.WriteLine(rezultat);

            Console.ReadKey();
        }

        static void Sabiranje(int broj)
        {
            rezultat += broj;
        }

        static void Mnozenje(int broj)
        {
            rezultat *= broj;
        }
    }
}
