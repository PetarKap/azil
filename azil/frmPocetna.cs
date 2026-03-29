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
}
