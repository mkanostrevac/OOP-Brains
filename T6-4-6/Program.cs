using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader ulaz = null;
            StreamWriter izlaz = null;

            try
            {
                ulaz = new StreamReader(@"D:\ITBrains\ulaz_4_5.txt");
                izlaz = new StreamWriter(@"D:\ITBrains\izlaz_4_5.txt");

                while (true)
                {
                    string line = ulaz.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    izlaz.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (ulaz != null)
                {
                    ulaz.Close();
                }
                if (izlaz != null)
                {
                    izlaz.Close();
                }
            }
        }
    }
}
