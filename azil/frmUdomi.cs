using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace azil
{
    public partial class frmUdomi : Form
    {
        string putanjaNoveDat = "udomljene.txt";
        string putanjaDatoteke = "zivotinje.txt";
        public frmUdomi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Zivotinja> zive = Admin.UcitajZivotinje();
            string linija = dateTimePicker1.Value.ToString("dd.MM.yyyy") + ";" + textBox2.Text + ";" + textBox3.Text;
            using (StreamWriter sw = new StreamWriter(putanjaNoveDat, true))
            {
                sw.WriteLine(linija);
            }
            using (StreamWriter sw = new StreamWriter("zivotinje.txt", false))//ja sam probao na ovi način zadovoljiti ovaj kriterij da više nije udomljena tako da ju maknem
            {
                foreach (var stavka in zive)
                {
                    sw.WriteLine(stavka.ToString());
                }
            }
            MessageBox.Show("Udomljena životinja je uspješno spremljena");
            textBox2.Clear();
            textBox3.Clear();
        }

        

        private void button2_Click(object sender, EventArgs e) // ovu funckiju sam napravio kako bi prikazao ostale životinje u azilu a to su sve ostale u datoteci zivotinje.txt
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

        private void frmUdomi_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
