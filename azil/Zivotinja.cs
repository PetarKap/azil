using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azil
{
    public class Zivotinja
    {
          public string ime { get; set; }
        public  string pasmina { get; set; }
        public string vrsta { get; set; }
        public int godine { get; set; }
        public RadioButton Spol { get; set; }
        public DateTime DatumDolaska { get; set; }
        public CheckBox Cijepljen { get; set; }
        public CheckBox Kastriran { get; set; }
        public  List<string> Napomena { get; set; }



    }
}
