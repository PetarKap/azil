using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azil
{
    public  class Admin
    {
        private static string filePath = "zivotinje.txt";
        public static void SpremiZivotinju(string zapis)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(zapis);
            }   
        }
        
    }
}
