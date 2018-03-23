using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ulaz = null;
            FileStream izlaz = null;

            try
            {
                ulaz = new FileStream(@"D:\ITBrains\ulaz_4_4.jpg", FileMode.Open, FileAccess.Read);
                izlaz = new FileStream(@"D:\ITBrains\izlaz_4_4.jpg", FileMode.Create, FileAccess.Write);

                int c;

                while ((c = ulaz.ReadByte()) != -1)
                {
                    izlaz.WriteByte((byte)c);
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

            Console.ReadKey();
        }
    }
}
