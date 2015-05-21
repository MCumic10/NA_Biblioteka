namespace NA_Biblioteka
{
    partial class BibliotekaAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotekaAdministrator));
            this.KljucneReciTB = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NaslovTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zaduzeneCHB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.izmeniOpisBTN = new System.Windows.Forms.Button();
            this.SadrzajRTB = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sacuvajUExcelBTN = new System.Windows.Forms.Button();
            this.knjigeTkuciMesecBTN = new System.Windows.Forms.Button();
            this.knjigePrethodniMesecBTN = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izmeniKorisnikaBTN = new System.Windows.Forms.Button();
            this.dodajKorisnikaBTN = new System.Windows.Forms.Button();
            this.izmeniKnjiguBTN = new System.Windows.Forms.Button();
            this.dodajKnjiguBTN = new System.Windows.Forms.Button();
            this.ZaduziBTN = new System.Windows.Forms.Button();
            this.tableAdapterManager = new NA_Biblioteka.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new NA_Biblioteka.BibliotekaDataSet();
            this.knjigaTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.KnjigaTableAdapter();
            this.zaduzenjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaduzenjeTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.ZaduzenjeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaduzenjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KljucneReciTB
            // 
            this.KljucneReciTB.Location = new System.Drawing.Point(25, 120);
            this.KljucneReciTB.Name = "KljucneReciTB";
            this.KljucneReciTB.Size = new System.Drawing.Size(134, 87);
            this.KljucneReciTB.TabIndex = 4;
            this.KljucneReciTB.Text = "";
            this.KljucneReciTB.TextChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ključne reči :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "LibID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naslov:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor:";
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(59, 71);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(100, 20);
            this.IDTB.TabIndex = 3;
            this.IDTB.TextChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(692, 606);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // NaslovTB
            // 
            this.NaslovTB.Location = new System.Drawing.Point(59, 45);
            this.NaslovTB.Name = "NaslovTB";
            this.NaslovTB.Size = new System.Drawing.Size(100, 20);
            this.NaslovTB.TabIndex = 1;
            this.NaslovTB.TextChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(59, 19);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(100, 20);
            this.AutorTB.TabIndex = 0;
            this.AutorTB.TextChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.zaduzeneCHB);
            this.groupBox1.Controls.Add(this.KljucneReciTB);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDTB);
            this.groupBox1.Controls.Add(this.NaslovTB);
            this.groupBox1.Controls.Add(this.AutorTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zadužene";
            // 
            // zaduzeneCHB
            // 
            this.zaduzeneCHB.AutoSize = true;
            this.zaduzeneCHB.Checked = true;
            this.zaduzeneCHB.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.zaduzeneCHB.Location = new System.Drawing.Point(144, 217);
            this.zaduzeneCHB.Name = "zaduzeneCHB";
            this.zaduzeneCHB.Size = new System.Drawing.Size(15, 14);
            this.zaduzeneCHB.TabIndex = 5;
            this.zaduzeneCHB.ThreeState = true;
            this.zaduzeneCHB.UseVisualStyleBackColor = false;
            this.zaduzeneCHB.CheckStateChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Početna strana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.izmeniOpisBTN);
            this.splitContainer2.Panel2.Controls.Add(this.SadrzajRTB);
            this.splitContainer2.Size = new System.Drawing.Size(692, 694);
            this.splitContainer2.SplitterDistance = 606;
            this.splitContainer2.TabIndex = 0;
            // 
            // izmeniOpisBTN
            // 
            this.izmeniOpisBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.izmeniOpisBTN.Location = new System.Drawing.Point(0, 61);
            this.izmeniOpisBTN.Name = "izmeniOpisBTN";
            this.izmeniOpisBTN.Size = new System.Drawing.Size(692, 23);
            this.izmeniOpisBTN.TabIndex = 9;
            this.izmeniOpisBTN.Text = "Izmeni opis";
            this.izmeniOpisBTN.UseVisualStyleBackColor = true;
            this.izmeniOpisBTN.Click += new System.EventHandler(this.izmeniOpisBTN_Click);
            // 
            // SadrzajRTB
            // 
            this.SadrzajRTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SadrzajRTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SadrzajRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SadrzajRTB.Location = new System.Drawing.Point(0, 0);
            this.SadrzajRTB.Name = "SadrzajRTB";
            this.SadrzajRTB.ReadOnly = true;
            this.SadrzajRTB.Size = new System.Drawing.Size(692, 60);
            this.SadrzajRTB.TabIndex = 8;
            this.SadrzajRTB.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.loginBTN);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.ZaduziBTN);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(892, 694);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sacuvajUExcelBTN);
            this.groupBox3.Controls.Add(this.knjigeTkuciMesecBTN);
            this.groupBox3.Controls.Add(this.knjigePrethodniMesecBTN);
            this.groupBox3.Location = new System.Drawing.Point(12, 503);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 140);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izveštaji";
            // 
            // sacuvajUExcelBTN
            // 
            this.sacuvajUExcelBTN.Location = new System.Drawing.Point(10, 107);
            this.sacuvajUExcelBTN.Name = "sacuvajUExcelBTN";
            this.sacuvajUExcelBTN.Size = new System.Drawing.Size(152, 23);
            this.sacuvajUExcelBTN.TabIndex = 7;
            this.sacuvajUExcelBTN.Text = "Sačuvaj prikaz u excel";
            this.sacuvajUExcelBTN.UseVisualStyleBackColor = true;
            this.sacuvajUExcelBTN.Click += new System.EventHandler(this.sacuvajUExcelBTN_Click);
            // 
            // knjigeTkuciMesecBTN
            // 
            this.knjigeTkuciMesecBTN.Location = new System.Drawing.Point(10, 64);
            this.knjigeTkuciMesecBTN.Name = "knjigeTkuciMesecBTN";
            this.knjigeTkuciMesecBTN.Size = new System.Drawing.Size(152, 37);
            this.knjigeTkuciMesecBTN.TabIndex = 7;
            this.knjigeTkuciMesecBTN.Text = "Dodate knjige tekućeg meseca";
            this.knjigeTkuciMesecBTN.UseVisualStyleBackColor = true;
            this.knjigeTkuciMesecBTN.Click += new System.EventHandler(this.knjigeTkuciMesecBTN_Click);
            // 
            // knjigePrethodniMesecBTN
            // 
            this.knjigePrethodniMesecBTN.Location = new System.Drawing.Point(10, 19);
            this.knjigePrethodniMesecBTN.Name = "knjigePrethodniMesecBTN";
            this.knjigePrethodniMesecBTN.Size = new System.Drawing.Size(152, 39);
            this.knjigePrethodniMesecBTN.TabIndex = 7;
            this.knjigePrethodniMesecBTN.Text = "Dodate knjige prethodnog meseca";
            this.knjigePrethodniMesecBTN.UseVisualStyleBackColor = true;
            this.knjigePrethodniMesecBTN.Click += new System.EventHandler(this.knjigePrethodniMesecBTN_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(12, 13);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(172, 23);
            this.loginBTN.TabIndex = 6;
            this.loginBTN.Text = "Prijavite se";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.izmeniKorisnikaBTN);
            this.groupBox2.Controls.Add(this.dodajKorisnikaBTN);
            this.groupBox2.Controls.Add(this.izmeniKnjiguBTN);
            this.groupBox2.Controls.Add(this.dodajKnjiguBTN);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administracija";
            this.groupBox2.Visible = false;
            // 
            // izmeniKorisnikaBTN
            // 
            this.izmeniKorisnikaBTN.Location = new System.Drawing.Point(10, 106);
            this.izmeniKorisnikaBTN.Name = "izmeniKorisnikaBTN";
            this.izmeniKorisnikaBTN.Size = new System.Drawing.Size(152, 23);
            this.izmeniKorisnikaBTN.TabIndex = 7;
            this.izmeniKorisnikaBTN.Text = "Izmeni korisnika";
            this.izmeniKorisnikaBTN.UseVisualStyleBackColor = true;
            this.izmeniKorisnikaBTN.Click += new System.EventHandler(this.izmeniKorisnikaBTN_Click);
            // 
            // dodajKorisnikaBTN
            // 
            this.dodajKorisnikaBTN.Location = new System.Drawing.Point(10, 48);
            this.dodajKorisnikaBTN.Name = "dodajKorisnikaBTN";
            this.dodajKorisnikaBTN.Size = new System.Drawing.Size(152, 23);
            this.dodajKorisnikaBTN.TabIndex = 7;
            this.dodajKorisnikaBTN.Text = "Dodaj korisnika";
            this.dodajKorisnikaBTN.UseVisualStyleBackColor = true;
            this.dodajKorisnikaBTN.Click += new System.EventHandler(this.dodajKorisnikaBTN_Click);
            // 
            // izmeniKnjiguBTN
            // 
            this.izmeniKnjiguBTN.Location = new System.Drawing.Point(10, 77);
            this.izmeniKnjiguBTN.Name = "izmeniKnjiguBTN";
            this.izmeniKnjiguBTN.Size = new System.Drawing.Size(152, 23);
            this.izmeniKnjiguBTN.TabIndex = 6;
            this.izmeniKnjiguBTN.Text = "Izmeni knjigu";
            this.izmeniKnjiguBTN.UseVisualStyleBackColor = true;
            this.izmeniKnjiguBTN.Click += new System.EventHandler(this.izmeniKnjiguBTN_Click);
            // 
            // dodajKnjiguBTN
            // 
            this.dodajKnjiguBTN.Location = new System.Drawing.Point(10, 19);
            this.dodajKnjiguBTN.Name = "dodajKnjiguBTN";
            this.dodajKnjiguBTN.Size = new System.Drawing.Size(152, 23);
            this.dodajKnjiguBTN.TabIndex = 6;
            this.dodajKnjiguBTN.Text = "Dodaj knjigu";
            this.dodajKnjiguBTN.UseVisualStyleBackColor = true;
            this.dodajKnjiguBTN.Click += new System.EventHandler(this.dodajKnjiguBTN_Click);
            // 
            // ZaduziBTN
            // 
            this.ZaduziBTN.Location = new System.Drawing.Point(12, 318);
            this.ZaduziBTN.Name = "ZaduziBTN";
            this.ZaduziBTN.Size = new System.Drawing.Size(172, 32);
            this.ZaduziBTN.TabIndex = 5;
            this.ZaduziBTN.Text = "Zaduži knjigu";
            this.ZaduziBTN.UseVisualStyleBackColor = true;
            this.ZaduziBTN.Visible = false;
            this.ZaduziBTN.Click += new System.EventHandler(this.ZaduziBTN_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NA_Biblioteka.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaduzenjeTableAdapter = null;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // zaduzenjeBindingSource
            // 
            this.zaduzenjeBindingSource.DataMember = "Zaduzenje";
            this.zaduzenjeBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // zaduzenjeTableAdapter
            // 
            this.zaduzenjeTableAdapter.ClearBeforeFill = true;
            // 
            // BibliotekaAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 694);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BibliotekaAdministrator";
            this.Text = "Biblioteka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BibliotekaAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaduzenjeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.RichTextBox KljucneReciTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NaslovTB;
        private System.Windows.Forms.TextBox AutorTB;
        private BibliotekaDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button izmeniOpisBTN;
        private System.Windows.Forms.RichTextBox SadrzajRTB;
        private System.Windows.Forms.Button ZaduziBTN;
        private System.Windows.Forms.BindingSource zaduzenjeBindingSource;
        private BibliotekaDataSetTableAdapters.ZaduzenjeTableAdapter zaduzenjeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajKorisnikaBTN;
        private System.Windows.Forms.Button dodajKnjiguBTN;
        private System.Windows.Forms.Button izmeniKorisnikaBTN;
        private System.Windows.Forms.Button izmeniKnjiguBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox zaduzeneCHB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sacuvajUExcelBTN;
        private System.Windows.Forms.Button knjigeTkuciMesecBTN;
        private System.Windows.Forms.Button knjigePrethodniMesecBTN;
        private System.Windows.Forms.Button button1;
    }
}