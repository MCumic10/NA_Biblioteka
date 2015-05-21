using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class DodajKorisnika : Form
    {
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void DodajKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bibliotekaDataSet.Korisnik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(imeTB.Text!="" && usernameTB.Text!="" && passwordTB.Text!="" && (int)accessLevelCB.SelectedIndex>=0){
                korisnikTableAdapter.Insert(imeTB.Text, passwordTB.Text, Convert.ToInt16(accessLevelCB.SelectedIndex + 1), adresaTB.Text, gradTB.Text, usernameTB.Text, telefonTB.Text, mailTB.Text);
                MessageBox.Show("Korisnik \"" + imeTB.Text + "\" je uspešno dodat.", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti polja \"Ime\", \"Username\", \"Password\" i \"Nivo pristupa\".", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
