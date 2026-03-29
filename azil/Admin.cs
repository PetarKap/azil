using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azil
{
    public class Admin
    {
        public static string filePath = "zivotinje.txt";
        public static void SpremiZivotinju(string zapis)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(zapis);
            }
        }
        public static List<Zivotinja> UcitajZivotinje()
        {
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');
                        Zivotinja k = new Zivotinja();
                        k.ime = podaci[0];

                        zivotinje.Add(k);

                    }
                }
            }
            return zivotinje;
        }
        public static List<string> PretraziZivotinje(string kriterij)
        {
            List<string> rezultat = new List<string>();
            List<Zivotinja> zivotinje = UcitajZivotinje();
            foreach (Zivotinja zivotinja in zivotinje)
            {
                if (zivotinja.vrsta.Contains(kriterij) || zivotinja.Status.Contains(kriterij))
                {
                    rezultat.Add(zivotinja.ime);
                }

            }
            return rezultat;

        }

        public static int BrojacZivotinja(string mate)
        {
            filePath = mate;

            int brojac = 0;
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        brojac++;
                    }
                }
            }
            return brojac;
        }

    }
}
