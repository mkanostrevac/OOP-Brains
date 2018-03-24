using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"D:\ITBrains\ulaz_4_5.txt";

            string[] nizStringova =
            {
                "ITBrains kurs se odrzava na Visoj Poslovnoj Skoli.",
                "Predavanja se odrzavaju utorkom, cetvrkom i subotom.",
                "Polaznici se obucavaju da programiraju koristeci programske jezike Java i C#."
            };

            UpisNizaStringovaUFajl(fajl, nizStringova);
            CitanjeNizaStringovaIzFajla(fajl);
        }

        static void UpisNizaStringovaUFajl(string putanjaFajla, string[] stringovi)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(putanjaFajla);

                foreach (var str in stringovi)
                {
                    sw.WriteLine(str);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            Console.WriteLine("Pritisni key za citanje stringova...");
            Console.ReadKey();
        }

        static void CitanjeNizaStringovaIzFajla(string putanjaFajla)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(putanjaFajla);

                while (true)
                {
                    string line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    Console.WriteLine(line); 
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
