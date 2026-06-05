using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AzilŽivotnije
{
    public partial class FormStatistika : Form
    {
        public FormStatistika()
        {
            InitializeComponent();
        }

        private void FormStatistika_Load(object sender, EventArgs e)
        {
            listBoxStatistika.Items.Clear();
            List<string> statistikaVrsta = AdminKlasa.VrsteBroj();
            foreach (string s in statistikaVrsta)
            {
                listBoxStatistika.Items.Add(s);
            }
            double prosjek = AdminKlasa.ProsjecnaDob();
            lblProsjek.Text = $"Prosječna dob životinja: {prosjek:F2} god.";
            List<string> sve = AdminKlasa.Ucitaj();
            int trenutno = AdminKlasa.BrojTrenutnih();
            int udomljenih = AdminKlasa.BrojUdomljenih();
            int ukupno = trenutno + udomljenih;
            lblTrenutno.Text = $"Trenutno u azilu: {trenutno}";
            lblUdomljeno.Text = $"Ukupno udomljenih: {udomljenih}";
            lblUkupno.Text = $"Ukupno životinja: {ukupno}";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminKlasa.IzvozExcel();
        }
    }
    }
