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
            Motor m = new Motor(true, "dizel", 100, 1999);

            m.Ukljuci();
            m.StampajPodatke();

            Console.Read();
        }
    }
}
