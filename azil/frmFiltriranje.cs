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
    public partial class frmFiltriranje : Form
    {
        string putanjaFiltera = "zivotinje.txt";
        public frmFiltriranje()
        {
            InitializeComponent();
        }

        private void frmFiltriranje_Load(object sender, EventArgs e)
        {

        }
        private void PrikaziSve()
        {
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Clear();

            List<Zivotinja> sveZivotinje = Admin.UcitajZivotinje();
            string odabrano = comboBoxVrsta.SelectedItem.ToString();

            for (int i = 0; i < sveZivotinje.Count; i++)
            {
                if (odabrano == "Ništa" || sveZivotinje[i].vrsta == odabrano)
                {
                    listBox1.Items.Add(sveZivotinje[i].ime + " - " + sveZivotinje[i].vrsta);
                }
                if(odabrano == "Ništa" || sveZivotinje[i].Status == odabrano)
                {
                    listBox1.Items.Add(sveZivotinje[i].ime + " - " + sveZivotinje[i].Status); ;
                }//ovjde sam pokušao poredati po statusu ili vrsti ali ne znam zašto mi ne radi ako još gore pozivam funkciju iz admin klase  koja savršeno radi jer 
                // sam uspio točno napraviti reset filtera 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxVrsta.SelectedIndex = 0;
            PrikaziSve();
        }
    }
    
}
