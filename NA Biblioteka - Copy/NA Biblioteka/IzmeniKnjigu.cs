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
            if (autorTB.Text != "" && naslovTB.Text != "")
            {
                knjigaTableAdapter.UpdateQueryByID(autorTB.Text, naslovTB.Text, gradTB.Text, godinaTB.Text, izdavacTB.Text, indeks);
                MessageBox.Show("Podaci knjige \"" + naslovTB.Text + "\" su uspešno izmenjena.", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti polja \"Autor\" i \"Naslov\".", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                textBox1.Text = red.LibID;
            }
            catch { } try
            {
                textBox2.Text = red.Vrednost.ToString();
            }
            catch { }
        }
    }
}
