using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class KorisniciList : Form
    {
        public KorisniciList()
        {
            InitializeComponent();
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void KorisniciList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bibliotekaDataSet.Korisnik);
            korisnikDataGridView.DataSource = korisnikTableAdapter.GetDataBy1List();
            for (int i = 0; i < 9; i++)
            {
                korisnikDataGridView.Columns[i].Visible = false;
            }
            foreach (DataGridViewRow red in korisnikDataGridView.Rows)
            {
                if (!(red.Cells[10].Value is DBNull))
                {
                    if (Convert.ToInt32(red.Cells[10].Value) == 3)
                    {
                        red.DefaultCellStyle.BackColor = Color.Orange;
                    }
                    if (Convert.ToInt32(red.Cells[10].Value) > 3)
                    {
                        red.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                }
            }
            korisnikDataGridView.Columns[1].Visible = korisnikDataGridView.Columns[9].Visible = true;
            korisnikDataGridView.Columns[9].DisplayIndex = 1;
            korisnikDataGridView.Columns[1].DisplayIndex = 2;

        }
        public BibliotekaAdministrator parent;
        private void korisnikDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da zadužite korisnika " + korisnikDataGridView.SelectedRows[0].Cells[1].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                parent.IDKorisnika = (int)korisnikDataGridView.SelectedRows[0].Cells[9].Value;
                this.Close();
            }
        }

        private void korisnikDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
        int ind = 0;
        private void korisnikDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                parent.IDKorisnika = ind;
                this.Close();
            }
        }

        private void korisnikDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            ind = (int)korisnikDataGridView.SelectedRows[0].Cells[9].Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = "";
            if (textBox1.Text != "")
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  ID = {0} ", textBox1.Text);
                }
                else
                {
                    rowFilter += string.Format("ID = {0} ", textBox1.Text);
                }
            }
            if (textBox2.Text != "")
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  Ime LIKE '*{0}*' ", textBox2.Text);
                }
                else
                {
                    rowFilter += string.Format("Ime LIKE '*{0}*' ", textBox2.Text);
                }
            }
            (korisnikDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            korisnikDataGridView.Update();
        }
    }
}
