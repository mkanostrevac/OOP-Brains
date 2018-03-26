using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_1
{
    class Spisak
    {
        List<Osoba> listaPolaznika;

        public Spisak()
        {
            listaPolaznika = new List<Osoba>();
        }

        public void UcitajListuPolaznika(string putanjaFajla)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(putanjaFajla);

                while (true)
                {
                    string podaci = sr.ReadLine();

                    if (podaci == null)
                    {
                        break;
                    }

                    Osoba polaznik = IsparsirajPodatkeOsobe(podaci);
                    listaPolaznika.Add(polaznik);
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
        }

        private Osoba IsparsirajPodatkeOsobe(string podaci)
        {
            string[] isparsiraniPodaci = podaci.Split(',');
            string ime = isparsiraniPodaci[0];
            string prezime = isparsiraniPodaci[1];
            string jmbg = isparsiraniPodaci[2];

            return new Osoba(ime, prezime, jmbg);
        }

        public void SortirajListuPolaznika()
        {
            listaPolaznika.Sort();
        }

        public void StampajListuPolaznika()
        {
            Console.WriteLine(Environment.NewLine + "Spisak polaznika");

            foreach (var polaznik in listaPolaznika)
            {
                Console.WriteLine(polaznik);
            }
        }

        public void UpisiListuPolaznika(string putanjaFajla)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(putanjaFajla);

                foreach (var polaznik in listaPolaznika)
                {
                    sw.WriteLine(polaznik);
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
        }
    }
}
