using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Koren(2, 3, -4));

            try
            {
                Console.WriteLine(Koren(0, 3, 4));

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(Koren(2, 3, 4));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
        
        static double Koren(double A, double B, double C)
        {
            if (A == 0)
            {
                throw new ArgumentException("A ne moze biti nula!");
            }
            else
            {
                double D = B * B - 4 * A * C;

                if (D <  0)
                {
                    throw new InvalidOperationException("Diskriminanta manja od nule!");
                }

                return (-B + Math.Sqrt(D)) / (2 * A);
            }
        }
    }
}
