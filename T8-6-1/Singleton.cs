using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_6_1
{
    public sealed class Singleton
    {
        private static Singleton instance;

        private Singleton() { }
        
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        public void Ispis(string poruka)
        {
            Console.WriteLine(poruka);
        }
    }
}
