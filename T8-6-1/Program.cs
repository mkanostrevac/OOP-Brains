using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton s = new Singleton();
            // 'Singleton.Singleton()' is inaccessible due to its protection level

            Singleton.Instance.Ispis("Pozivanje metode prvi put");
            Singleton.Instance.Ispis("Pozivanje metode drugi put");
        }
    }
}
