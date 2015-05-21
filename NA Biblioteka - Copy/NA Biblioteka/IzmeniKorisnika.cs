using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class IzmeniKorisnika : Form
    {
        public IzmeniKorisnika()
        {
            InitializeComponent();
        }
        public int indeks;
        private void button1_Click(object sender, EventArgs e)
        {
            if (imeTB.Text != "" && usernameTB.Text != "" && passwordTB.Text != "" && (int)accessLevelCB.SelectedIndex >= 0)
            {
                korisnikTableAdapter.UpdateQueryByID(imeTB.Text, passwordTB.Text, Convert.ToInt16(accessLevelCB.SelectedIndex + 1), adresaTB.Text, gradTB.Text, usernameTB.Text, telefonTB.Text, mailTB.Text,indeks);
                MessageBox.Show("Podaci korisnika \"" + imeTB.Text + "\" su uspešno izmenjeni.", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate popuniti polja \"Ime\", \"Username\", \"Password\" i \"Nivo pristupa\".", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public BibliotekaDataSet.KorisnikRow red;
        private void IzmeniKorisnika_Load(object sender, EventArgs e)
        {

            red = korisnikTableAdapter.GetDataByID(indeks)[0];
            try {
                imeTB.Text = red.Ime;
            }
            catch { } try { 
            passwordTB.Text = red.Password;
            }
            catch { } try { 
            usernameTB.Text = red.Username;
            }
            catch { } try { 
            adresaTB.Text = red.Adresa;
            }
            catch { } try { 
            gradTB.Text = red.Grad;
            }
            catch { } try { 
            telefonTB.Text = red.brTel;
            }
            catch { } try { 
            mailTB.Text = red.mail;
            }
            catch { } try { 
            accessLevelCB.SelectedIndex = red.AccessLevel - 1;
            }
            catch { }
        }
    }
}
