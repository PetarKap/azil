using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azil
{
    public partial class frmStatistika : Form
    {
        string putanjaDatoteke = "zivotinje.txt";
        string putanjaUdomljenih = "udomljene.txt";
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            // nisam uspio napravtiti posljednju
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brojacTrenutnih = Admin.BrojacZivotinja(putanjaDatoteke);


            MessageBox.Show("Trenutno u azilu se nalazi " + brojacTrenutnih + " životinja.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int brojacUdomljenih = Admin.BrojacZivotinja(putanjaUdomljenih);


            MessageBox.Show("Trenutno u azilu se nalazi " + brojacUdomljenih + " životinja.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Prosjek = 0;
            int zbrojgodina1 = 0;
            int zbrojgodina2 = 0;
            int ukupno=0;
            using (StreamReader sr = new StreamReader(putanjaDatoteke))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                   

                        string[] dijelovi = linija.Split('|');

                        if (dijelovi.Length >= 6)
                        {
                        int godine = int.Parse(dijelovi[5].Trim());
                        zbrojgodina1 += godine;

                        }
                    
                }
            }
            using (StreamReader sr = new StreamReader(putanjaUdomljenih))// kod ove funkcije sam kasno shvatio kako maknuti udomljnene iz datoteke zivotinje.txt u udomljene
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {


                    string[] dijelovi = linija.Split('|');

                    if (dijelovi.Length >= 6)
                    {
                        int godine = int.Parse(dijelovi[5].Trim());
                        zbrojgodina2 += godine;

                    }

                }
            }
            ukupno = zbrojgodina1 + zbrojgodina2;
            Prosjek = ukupno / (Admin.BrojacZivotinja(putanjaDatoteke) + Admin.BrojacZivotinja(putanjaUdomljenih));
            MessageBox.Show("Prosječna dob svih životinja u azilu je " + Prosjek + " godina.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists(putanjaDatoteke))
            {
                StreamReader sr = new StreamReader(putanjaDatoteke);

                string red;

                while ((red = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(red);
                }

                sr.Close();
            }
        }
    }
}
