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

            
            if (podaci.Length < 5)
                return;

            
            Ime.Text = podaci[0];
            txtVrsta.Text = podaci[1];
            txtDob.Text = podaci[2];
            txtStatus.Text = podaci[3];

            
            try
            {
                if (File.Exists(podaci[4]))
                {
                    pictureBox1.Image = Image.FromFile(podaci[4]);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }
    }
    }
}
