using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*2*/
namespace NA_Biblioteka
{
    public partial class BibliotekaAdministrator : Form
    {
        public BibliotekaAdministrator()
        {
            InitializeComponent();
        }
        public int nivoPristupa=0;
        private void BibliotekaAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Zaduzenje' table. You can move, or remove it, as needed.
            this.zaduzenjeTableAdapter.Fill(this.bibliotekaDataSet.Zaduzenje);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.bibliotekaDataSet.Knjiga);
            dataGridView1.DataSource = knjigaTableAdapter.GetDataByAdminView();
            dataGridView1.Update();
            dataGridView1.Columns[9].DisplayIndex = 11;
            dataGridView1.Columns[10].DisplayIndex = 12;
            dataGridView1.Columns[11].DisplayIndex = 9;
            dataGridView1.Columns[12].DisplayIndex = 10;
            setNivoPristupaVisible();
            dataGridView1.Columns[7].Visible = false;
            refreshDataGrid();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].Width = 110;
            dataGridView1.Columns[7].Width = 90;
            dataGridView1.Columns[8].Width = 90;

        }

        private void setNivoPristupaVisible()
        {
            if (nivoPristupa == 3)
            {
                groupBox3.Visible = groupBox2.Visible = true;
                ZaduziBTN.Visible = true;
                dataGridView1.Columns[12].Visible = dataGridView1.Columns[11].Visible = dataGridView1.Columns[10].Visible = dataGridView1.Columns[9].Visible = true;
            }
            else if (nivoPristupa == 2)
            {
                groupBox3.Visible = groupBox2.Visible = false;
                ZaduziBTN.Visible = true;
                dataGridView1.Columns[12].Visible = dataGridView1.Columns[11].Visible = dataGridView1.Columns[10].Visible = dataGridView1.Columns[9].Visible = true;
            }
            else
            {
                groupBox3.Visible = groupBox2.Visible = false;
                ZaduziBTN.Visible = false;
                dataGridView1.Columns[12].Visible = dataGridView1.Columns[11].Visible = dataGridView1.Columns[10].Visible = dataGridView1.Columns[9].Visible = false;
            }
        }
        private void farbajRedove()
        {            
            foreach (DataGridViewRow red in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(red.Cells[8].Value))
                {
                    red.DefaultCellStyle.BackColor = Color.Cyan;
                }
                //if (!(red.Cells[13].Value is DBNull))
                //{
                //    if (Convert.ToInt32(red.Cells[13].Value) == 3)
                //    {
                //        red.DefaultCellStyle.BackColor = Color.Orange;
                //    }
                //    if (Convert.ToInt32(red.Cells[13].Value) > 3)
                //    {
                //        red.DefaultCellStyle.BackColor = Color.OrangeRed;
                //    }
                //}

                red.HeaderCell.Value = String.Format("{0}", red.Index + 1);
            }
        }
        /*
         
         
         
         */
        private void refreshDataGrid()
        {
            GridUtility.SaveSorting(dataGridView1);
            dataGridView1.DataSource = knjigaTableAdapter.GetDataByAdminView();
            dataGridView1.Update();
            GridUtility.RestoreSorting(dataGridView1);
            farbajRedove();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SadrzajRTB.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[8].Value))
                {
                    ZaduziBTN.Text = "Razduži knjigu";
                }
                else
                {
                    ZaduziBTN.Text = "Zaduži knjigu";
                }
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
            string rowFilter = "";
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
            if (zaduzeneCHB.CheckState!= CheckState.Indeterminate)
            {
                if (rowFilter.Length > 0)
                {
                    rowFilter += string.Format(" AND  Zaduzena = {0} ", zaduzeneCHB.Checked);
                }
                else
                {
                    rowFilter += string.Format("Zaduzena = {0} ", zaduzeneCHB.Checked);
                }
            }
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
            farbajRedove();
        }

        private bool uIzmeni = false;
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
                dataGridView1.Update();
            }
        }
        public int IDKorisnika;
        private void ZaduziBTN_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[8].Value))
            {
                if (MessageBox.Show("Da li ste sigurni da želite da razdužite knjigu " + dataGridView1.SelectedRows[0].Cells[2].Value + "?\nKorisnik: " + dataGridView1.SelectedRows[0].Cells[11].Value, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    // ZaduziBTN.Text = "Razduži knjigu";
                    knjigaTableAdapter.UpdateQueryRazduziKnjigu((int)Math.Abs((int)(dataGridView1.SelectedRows[0].Cells[0].Value)));
                    zaduzenjeTableAdapter.UpdateQueryRazduziKnjigu((int)Math.Abs((int)(dataGridView1.SelectedRows[0].Cells[0].Value)));
                    refreshDataGrid();
                    IDKorisnika = 0;
                    MessageBox.Show("Korisnik je razdužen", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //ZaduziBTN.Text = "Zaduži knjigu";
                KorisniciList kl = new KorisniciList();
                kl.parent = this;
                kl.ShowDialog();
                if (IDKorisnika > 0)
                {
                    knjigaTableAdapter.UpdateQueryZaduziKnjigu((int)Math.Abs((int)(dataGridView1.SelectedRows[0].Cells[0].Value)));
                    zaduzenjeTableAdapter.InsertQueryZaduziKnjigu(IDKorisnika, (int)Math.Abs((int)(dataGridView1.SelectedRows[0].Cells[0].Value)), DateTime.Now.Date);
                    refreshDataGrid();
                    IDKorisnika = 0;
                    MessageBox.Show("Korisnik je zadužen", "Biblioteka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dodajKnjiguBTN_Click(object sender, EventArgs e)
        {
            DodajKnjigu dk = new DodajKnjigu();
            dk.ShowDialog();
            refreshDataGrid();
        }

        private void dodajKorisnikaBTN_Click(object sender, EventArgs e)
        {
            DodajKorisnika dk = new DodajKorisnika();
            dk.ShowDialog();
            refreshDataGrid();
        }

        private void izmeniKnjiguBTN_Click(object sender, EventArgs e)
        {
            IzmeniKnjigu ik = new IzmeniKnjigu();
            ik.indeks = (int)Math.Abs((int)(dataGridView1.SelectedRows[0].Cells[0].Value));
            ik.ShowDialog();
            refreshDataGrid();
        }

        private void izmeniKorisnikaBTN_Click(object sender, EventArgs e)
        {
            KorisniciList kl = new KorisniciList();
            kl.parent = this;
            kl.ShowDialog();
            if (IDKorisnika > 0)
            {
                IzmeniKorisnika ik = new IzmeniKorisnika();
                ik.indeks = IDKorisnika;
                ik.ShowDialog();
            }
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (nivoPristupa <= 0)
            {
                LogIn li = new LogIn();
                li.bK = this;
                li.ShowDialog();
                setNivoPristupaVisible();
                loginBTN.Text = "Odjavite se";
            }
            else
            {
                nivoPristupa = 0;
                loginBTN.Text = "Prijavite se";
                setNivoPristupaVisible();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            farbajRedove();
        }

        private void knjigePrethodniMesecBTN_Click(object sender, EventArgs e)
        {
            string rowFilter = "";
            rowFilter = "DatumUnosa < '"+DateTime.Now.AddDays(-(DateTime.Now.Day)).Date.ToShortDateString()+"' AND DatumUnosa > '"+DateTime.Now.AddDays(-(DateTime.Now.Day-1)).AddMonths(-1).Date.ToShortDateString()+"'";
            
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
            farbajRedove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowFilter = "";
            AutorTB.Text = NaslovTB.Text = IDTB.Text = KljucneReciTB.Text = "";
            zaduzeneCHB.CheckState = CheckState.Indeterminate;

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
            farbajRedove();
        }

        private void knjigeTkuciMesecBTN_Click(object sender, EventArgs e)
        {
            string rowFilter = "";
            rowFilter = "DatumUnosa > '" + DateTime.Now.AddDays(-(DateTime.Now.Day - 1)).ToShortDateString()+"'";

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
            farbajRedove();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void sacuvajUExcelBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "Izvestaj biblioteka " + DateTime.Now.ToString("dd.MM.yyyy") + ".xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsV(dataGridView1, sfd.FileName); 
                }
            }
            catch
            {
                MessageBox.Show("Greska pri cuvanju dokumenta. Proverite da dokument nije otvoren pa pokusajte ponovo.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string rowFilter = "";
            rowFilter = "DatumUnosa < '" + dateTimePicker2.Value.Date.ToShortDateString() + "' AND DatumUnosa > '" + dateTimePicker1.Value.Date.ToShortDateString() + "'";

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView1.Update();
            farbajRedove();
        }  
    }

    public class GridUtility
    {
        private static ListSortDirection _oldSortOrder;
        private static DataGridViewColumn _oldSortCol;

        /// <summary>
        /// Saves information about sorting column, to be restored later by calling RestoreSorting
        /// on the same DataGridView
        /// </summary>
        /// <param name="grid"></param>
        public static void SaveSorting(DataGridView grid)
        {
            _oldSortOrder = grid.SortOrder == SortOrder.Ascending ?
                ListSortDirection.Ascending : ListSortDirection.Descending;
            _oldSortCol = grid.SortedColumn;
        }

        /// <summary>
        /// Restores column sorting to a datagrid. You MUST call this AFTER calling 
        /// SaveSorting on the same DataGridView
        /// </summary>
        /// <param name="grid"></param>
        public static void RestoreSorting(DataGridView grid)
        {
            if (_oldSortCol != null)
            {
                DataGridViewColumn newCol = grid.Columns[_oldSortCol.Name];
                grid.Sort(newCol, _oldSortOrder);
            }
        }
    }
}
