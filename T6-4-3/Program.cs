using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"D:\ITBrains\ulaz_4_3.txt";

            byte[] nizBajtova = {Byte.MinValue, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 200, Byte.MaxValue };

            UpisNizaBajtovaUFajl(fajl, nizBajtova);
            CitanjeNizaBajtovaIzFajla(fajl);
        }

        static void UpisNizaBajtovaUFajl(string putanjaFajla, byte[] bajtovi)
        {
            FileStream tokBajtova = null;

            try
            {
                tokBajtova = new FileStream(putanjaFajla, FileMode.Create, FileAccess.Write);

                foreach (var bajt in bajtovi)
                {
                    tokBajtova.WriteByte(bajt);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (tokBajtova != null)
                {
                    tokBajtova.Close();
                }
            }

            Console.WriteLine("Pritisni key za citanje bajtova...");
            Console.ReadKey();
        }

        static void CitanjeNizaBajtovaIzFajla(string putanjaFajla)
        {
            FileStream tokBajtova = null;

            try
            {
                tokBajtova = new FileStream(putanjaFajla, FileMode.Open, FileAccess.Read);

                int c;

                while ((c = tokBajtova.ReadByte()) != -1)
                {
                    Console.WriteLine(c);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (tokBajtova != null)
                {
                    tokBajtova.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
