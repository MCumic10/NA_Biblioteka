using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NA_Biblioteka
{
    public partial class BibliotekaAdmin : Form
    {
        public BibliotekaAdmin()
        {
            InitializeComponent();
        }

        private void BibliotekaKorisnik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.bibliotekaDataSet.Knjiga);
            dataGridView1.DataSource = knjigaTableAdapter.GetDataByKorisnik();
            dataGridView1.Update();
            dataGridView1.Columns[0].Visible = dataGridView1.Columns[7].Visible = false;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SadrzajRTB.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        /// <summary>
        /// Event koj se opaljuje kad god se promeni filter.
        /// Filtrira redove u dataGridView1 kontroli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutorTB_TextChanged(object sender, EventArgs e)
        {
            string rowFilter="";
            if (AutorTB.Text != "")
            {
                rowFilter += string.Format("Autor LIKE '*{0}*'", AutorTB.Text);
            }
            if (NaslovTB.Text != "")
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  Naslov LIKE '*{0}*' ", NaslovTB.Text);
                }
                else
                {
                    rowFilter += string.Format("Naslov LIKE '*{0}*' ", NaslovTB.Text);
                }
            }
            if (IzdavacTB.Text != "")
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  Izdavac LIKE '*{0}*' ", IzdavacTB.Text);
                }
                else
                {
                    rowFilter += string.Format("Izdavac LIKE '*{0}*' ", IzdavacTB.Text);
                }
            }
            if (IDTB.Text != "")
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  LibID LIKE '*{0}*' ", IDTB.Text);
                }
                else
                {
                    rowFilter += string.Format("LibID LIKE '*{0}*' ", IDTB.Text);
                }
            }
            if (KljucneReciTB.Text != "")
            {
                string[] kljucneReci = KljucneReciTB.Text.Split(' ');
                for (int i = 0; i < kljucneReci.Length; i++)
                {
                    if (rowFilter.Length > 0)
                    {
                        rowFilter += "AND";
                    }
                    rowFilter += string.Format(" Sadrzaj LIKE'*{0}*'", kljucneReci[i]);
                }
            }
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
        }
        private bool uIzmeni=false;
        private void izmeniOpisBTN_Click(object sender, EventArgs e)
        {
            if (!uIzmeni)
            {
                SadrzajRTB.ReadOnly = false;
                uIzmeni = true;
                izmeniOpisBTN.Text = "Snimi opis";
            }
            else
            {
                uIzmeni = false;
                SadrzajRTB.ReadOnly = true;
                izmeniOpisBTN.Text = "Izmeni opis";
                knjigaTableAdapter.UpdateQuerySetSadrzaj(SadrzajRTB.Text, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            }
        }
    }
}
