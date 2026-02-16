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
         string ime { get; set; }
         string pasmina { get; set; }
        string vrsta { get; set; }
        int godine { get; set; }
        RadioButton Spol { get; set; }
        DateTime DatumDolaska { get; set; }
        CheckBox Cijepljen { get; set; }
        CheckBox Kastriran { get; set; }
        List<string> Napomena { get; set; }



    }
}
