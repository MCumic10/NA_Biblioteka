using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class IzmeniKnjigu : Form
    {
        public IzmeniKnjigu()
        {
            InitializeComponent();
        }
        public int indeks;
        private void button1_Click(object sender, EventArgs e)
        {
            if (naslovTB.Text != "" && libIDTB.Text != "" && comboBox1.SelectedIndex >= 0)
            {
                knjigaTableAdapter.UpdateQueryByID(autorTB.Text, naslovTB.Text, gradTB.Text, godinaTB.Text, izdavacTB.Text, indeks);
                MessageBox.Show("Podaci knjige \"" + naslovTB.Text + "\" su uspešno izmenjena.", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti polja \"Naslov\" i \"LibID\".", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public BibliotekaDataSet.KnjigaRow red;
        private void IzmeniKnjigu_Load(object sender, EventArgs e)
        {
            red = knjigaTableAdapter.GetDataByID(indeks)[0];
            try
            {
                autorTB.Text = red.Autor;
            }
            catch { } try
            {
                naslovTB.Text = red.Naslov;
            }
            catch { } try
            {
                gradTB.Text = red.Grad;
            }
            catch { } try
            {
                godinaTB.Text = red.Godina;
            }
            catch { } try
            {
                izdavacTB.Text = red.Izdavac;
            }
            catch { } try
            {
                libIDTB.Text = red.LibID.Substring(red.LibID.LastIndexOf('-') + 1);
                if (red.LibID.StartsWith("REL")) { comboBox1.SelectedIndex = 0; }
                if (red.LibID.StartsWith("IST")) { comboBox1.SelectedIndex = 1; }
                if (red.LibID.StartsWith("FIL")) { comboBox1.SelectedIndex = 2; }
                if (red.LibID.StartsWith("MIT")) { comboBox1.SelectedIndex = 3; }
            }
            catch { } try
            {
                vrednostTB.Text = red.Vrednost.ToString();
            }
            catch { }
        }
        private bool prvaPromena = true;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!prvaPromena)
            {
                int nextVal = (int)knjigaTableAdapter.maxLibIDSuffix(comboBox1.Text) + 1;
                libIDTB.Text = nextVal.ToString();
            }
            else { prvaPromena = false; }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
