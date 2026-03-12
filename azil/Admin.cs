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
        private static string filePath = "zivotinje.txt";
        public static void SpremiZivotinju(string zapis)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(zapis);
            }
        }
        public static List<string> UcitajZivotinje()
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
            List<string> zivotinje = UcitajZivotinje();
            foreach (string zivotinja in zivotinje)
            {
                if (zivotinja.Contains(kriterij))
                {
                    rezultat.Add(zivotinja);
                }
            }
            return rezultat;

        }
    } 
    public static List<string> Pretvori()
        {
            List<string> rezultat = new List<string>();
            List<ZI>


        } 
    
    }

}
