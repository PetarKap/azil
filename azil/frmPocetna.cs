using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azil
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
      
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmUnosZivotinje = new frmUnosZivotinje();
            frmUnosZivotinje.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmPregledZivotinja = new frmPregled();
            frmPregledZivotinja.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmFiltriranje = new frmFiltriranje();
            frmFiltriranje.ShowDialog();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmUdomljavanje = new frmUdomi();
            frmUdomljavanje.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frmStatistika = new frmStatistika();
            frmStatistika.ShowDialog();
        }
    }
}// Pozdrav profesore , ovu poruku vamn šaljem kako bi manje gubili vrime tražeći moje greške . Dao sam sve od sebe i trudio sam se pisati kod koji razumijem jer nije mi cilj pisati 
// i prepisivati tuđi pa da me još uhvatite . mislim da će najveća moja greška ovdje bila ta što sam u jednom dijelu slučajno izbrisao funckiju za dodavanje stvari u listboxi da mi je 
// zbog toga došlo to tih grešaka ali mislim da ako zanemarite to onda je većina koda uredu (osim dijela za combo box na formi za filtriranje) . Pitajte me uživo bilo što i odgovorit ću vam 
// ako vam nije bilo jasno i molim Vas ne bude strogi 
