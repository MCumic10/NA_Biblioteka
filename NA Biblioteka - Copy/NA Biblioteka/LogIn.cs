using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        public BibliotekaAdministrator bK;
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks = korisnikTableAdapter.GetDataByUsernamePassword(PasswordTB.Text, UsernameTB.Text)[0].AccessLevel;
                bK.nivoPristupa = indeks;
                this.Close();
                greskaLB.Visible = false;
                PasswordTB.Text = "";
                UsernameTB.Text = "";
                bK.ShowDialog();
            }
            catch(Exception ex)
            {
                greskaLB.Visible = true;
                PasswordTB.Text = "";
            }
            //this.Close();
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bibliotekaDataSet.Korisnik);

        }
    }
}
