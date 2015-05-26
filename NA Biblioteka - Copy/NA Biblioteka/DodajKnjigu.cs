using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class DodajKnjigu : Form
    {
        public DodajKnjigu()
        {
            InitializeComponent();
        }

        private void knjigaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knjigaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void DodajKnjigu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bibliotekaDataSet.Korisnik);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.bibliotekaDataSet.Knjiga);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (naslovTB.Text != "" && libIDTB.Text != "" && comboBox1.SelectedIndex>=0)
            {
                knjigaTableAdapter.Insert(autorTB.Text, naslovTB.Text, gradTB.Text, godinaTB.Text, izdavacTB.Text,comboBox1.Text + libIDTB.Text, "", false, DateTime.Now, Convert.ToDecimal(string.IsNullOrEmpty( vrednostTB.Text)?"0":vrednostTB.Text));
                MessageBox.Show("Knjiga \"" + naslovTB.Text + "\" je uspešno dodata.", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti polja \"Naslov\" i \"LibID\".", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nextVal = (int)knjigaTableAdapter.maxLibIDSuffix(comboBox1.Text) + 1;
            libIDTB.Text = nextVal.ToString();
        }
    }
}
