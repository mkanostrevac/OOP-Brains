using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] M = new int[][] 
            {
                new int [] { 1, 2},
                new int [] { 3, 4}
            };

            Console.WriteLine(IzracunajDeterminantu(M));

            M = new int[][]
            {
                new int [] { 1 }
            };

            Console.WriteLine(IzracunajDeterminantu(M));
            Console.WriteLine(IzracunajDeterminantu(null));
            Console.ReadKey();
        }

        static double IzracunajDeterminantu(int [][] M)
        {
            try
            {
                return M[0][0] * M[1][1] - M[0][1] * M[1][0];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("M nije ispravne velicine!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("M ne postoji!");
            }

            return 0;
        }
    }
}
