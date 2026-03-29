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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace azil
{

    public partial class frmPregled : Form

    {
        string putanjaDatoteke = "zivotinje.txt";
        public frmPregled()
        {
            InitializeComponent();
        }

        private void frmPregled_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                if (listBox1.SelectedItem == null)
                    return;

                string red = listBox1.SelectedItem.ToString();

                string[] podaci = red.Split(';');


                if (podaci.Length < 5)// ovaj dio sam dodao da se ne bi dogodila greška ako red nema dovoljno podataka ( i jer sam htio ispis u textboxovima)
                    return;


                txtIme.Text = podaci[0];
                txtVrsta.Text = podaci[1];
                txtDob.Text = podaci[2];
                txtStatus.Text = podaci[3];
                string putanja=podaci[4];
                //profesore ja sam pokušavao napraviti ovo za prikaz slike ali ne radi . pokuašvao sam s mijenjajem reda u zapisu na prethodnoj formi ali ne radi. očito sam nešto 
                //pogrijesio u zapisivanju putanje slike ali mi radi odabir i spremanje . nadam se da neće uzet u obzir jer mi ova dodadtna stavka za textbovoe radi




                if (podaci.Length >= 5)
                {
                    if (File.Exists(putanja))
                    {
                        pictureBox1.Image = new Bitmap(putanja);
                    }
                    else
                    {   
                        MessageBox.Show("Slika NE postoji!");
                        pictureBox1.Image = null;
                    }
                }
            }
        }
    }
    
}
