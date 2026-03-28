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
    public partial class frmUnosZivotinje : Form
    {
        string putanjaSlike = ""; 
        public frmUnosZivotinje()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               if( pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                pictureBox1.Image = Image.FromFile(ofd.FileName);   
                ofd.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija = imetxt.Text+";" + vrstatxt.Text + ";"+Pasminatxt.Text+";"+radioButton1.Checked.ToString()+";"+ radioButton2.Checked.ToString() + 
             Napomenatxt.Text+";"+pictureBox1.ImageLocation;
            System.IO.File.AppendAllText("zivotinje.txt", linija + Environment.NewLine);
            string ime_slike= openFileDialog1.FileName;
            string odredisna_putanja = System.IO.Path.Combine(Application.StartupPath, "slike", System.IO.Path.GetFileName(ime_slike));
            MessageBox.Show("Slika i pas su uspješno spremni");
            Admin.SpremiZivotinju(linija);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            // filter za slike
            ofd.Filter = "Slike (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            // naslov prozora
            ofd.Title = "Odaberi sliku životinje";

            // otvaranje dijaloga
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // spremi putanju
                putanjaSlike = ofd.FileName;

                // prikaži sliku u PictureBoxu
                pictureBox1.Image = Image.FromFile(putanjaSlike);
            }
        }

        private void frmUnosZivotinje_Load(object sender, EventArgs e)
        {

        }
    }
}
