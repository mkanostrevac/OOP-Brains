using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_5_3
{
    class SnimacPodataka
    {
        private string putanjaFajla;

        public SnimacPodataka(string putanjaFajla)
        {
            this.putanjaFajla = putanjaFajla;
        }

        public void ZapisiPorukuUFajl(string poruka)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(putanjaFajla, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(poruka);
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
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
