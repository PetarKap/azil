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
            Form frmUnosZivotinje = new Form();
            frmUnosZivotinje.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmPregledZivotinja = new Form();
            frmPregledZivotinja.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmFiltriranje = new Form();
            frmFiltriranje.ShowDialog();
        }
    }
}
