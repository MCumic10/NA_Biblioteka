namespace NA_Biblioteka
{
    partial class DodajKnjigu
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
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label naslovLabel;
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label godinaLabel;
            System.Windows.Forms.Label izdavacLabel;
            System.Windows.Forms.Label libIDLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajKnjigu));
            this.autorTB = new System.Windows.Forms.TextBox();
            this.naslovTB = new System.Windows.Forms.TextBox();
            this.gradTB = new System.Windows.Forms.TextBox();
            this.godinaTB = new System.Windows.Forms.TextBox();
            this.izdavacTB = new System.Windows.Forms.TextBox();
            this.libIDTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vrednostTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bibliotekaDataSet = new NA_Biblioteka.BibliotekaDataSet();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.KnjigaTableAdapter();
            this.tableAdapterManager = new NA_Biblioteka.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.korisnikTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.KorisnikTableAdapter();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            autorLabel = new System.Windows.Forms.Label();
            naslovLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            godinaLabel = new System.Windows.Forms.Label();
            izdavacLabel = new System.Windows.Forms.Label();
            libIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(32, 15);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 0;
            autorLabel.Text = "Autor:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new System.Drawing.Point(24, 49);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(43, 13);
            naslovLabel.TabIndex = 2;
            naslovLabel.Text = "Naslov:";
            // 
            // gradLabel
            // 
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(34, 151);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(33, 13);
            gradLabel.TabIndex = 4;
            gradLabel.Text = "Grad:";
            // 
            // godinaLabel
            // 
            godinaLabel.AutoSize = true;
            godinaLabel.Location = new System.Drawing.Point(23, 117);
            godinaLabel.Name = "godinaLabel";
            godinaLabel.Size = new System.Drawing.Size(44, 13);
            godinaLabel.TabIndex = 6;
            godinaLabel.Text = "Godina:";
            // 
            // izdavacLabel
            // 
            izdavacLabel.AutoSize = true;
            izdavacLabel.Location = new System.Drawing.Point(19, 83);
            izdavacLabel.Name = "izdavacLabel";
            izdavacLabel.Size = new System.Drawing.Size(48, 13);
            izdavacLabel.TabIndex = 8;
            izdavacLabel.Text = "Izdavac:";
            // 
            // libIDLabel
            // 
            libIDLabel.AutoSize = true;
            libIDLabel.Location = new System.Drawing.Point(29, 185);
            libIDLabel.Name = "libIDLabel";
            libIDLabel.Size = new System.Drawing.Size(38, 13);
            libIDLabel.TabIndex = 10;
            libIDLabel.Text = "Lib ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 219);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 10;
            label1.Text = "Vrednost:";
            // 
            // autorTB
            // 
            this.autorTB.Location = new System.Drawing.Point(73, 12);
            this.autorTB.Name = "autorTB";
            this.autorTB.Size = new System.Drawing.Size(134, 20);
            this.autorTB.TabIndex = 0;
            // 
            // naslovTB
            // 
            this.naslovTB.Location = new System.Drawing.Point(73, 46);
            this.naslovTB.Name = "naslovTB";
            this.naslovTB.Size = new System.Drawing.Size(134, 20);
            this.naslovTB.TabIndex = 1;
            // 
            // gradTB
            // 
            this.gradTB.Location = new System.Drawing.Point(73, 148);
            this.gradTB.Name = "gradTB";
            this.gradTB.Size = new System.Drawing.Size(134, 20);
            this.gradTB.TabIndex = 2;
            // 
            // godinaTB
            // 
            this.godinaTB.Location = new System.Drawing.Point(73, 114);
            this.godinaTB.Name = "godinaTB";
            this.godinaTB.Size = new System.Drawing.Size(134, 20);
            this.godinaTB.TabIndex = 3;
            // 
            // izdavacTB
            // 
            this.izdavacTB.Location = new System.Drawing.Point(73, 80);
            this.izdavacTB.Name = "izdavacTB";
            this.izdavacTB.Size = new System.Drawing.Size(134, 20);
            this.izdavacTB.TabIndex = 4;
            // 
            // libIDTB
            // 
            this.libIDTB.Location = new System.Drawing.Point(177, 182);
            this.libIDTB.Name = "libIDTB";
            this.libIDTB.Size = new System.Drawing.Size(30, 20);
            this.libIDTB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vrednostTB
            // 
            this.vrednostTB.Location = new System.Drawing.Point(73, 216);
            this.vrednostTB.Name = "vrednostTB";
            this.vrednostTB.Size = new System.Drawing.Size(134, 20);
            this.vrednostTB.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "REL 40-201-",
            "IST 30-201-",
            "FIL 20-201-",
            "MIT 50-201-"});
            this.comboBox1.Location = new System.Drawing.Point(73, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KnjigaTableAdapter = this.knjigaTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.UpdateOrder = NA_Biblioteka.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaduzenjeTableAdapter = null;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // DodajKnjigu
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 314);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vrednostTB);
            this.Controls.Add(this.libIDTB);
            this.Controls.Add(this.izdavacTB);
            this.Controls.Add(this.godinaTB);
            this.Controls.Add(this.gradTB);
            this.Controls.Add(this.naslovTB);
            this.Controls.Add(label1);
            this.Controls.Add(this.autorTB);
            this.Controls.Add(libIDLabel);
            this.Controls.Add(izdavacLabel);
            this.Controls.Add(godinaLabel);
            this.Controls.Add(gradLabel);
            this.Controls.Add(naslovLabel);
            this.Controls.Add(autorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajKnjigu";
            this.Text = "DodajKnjigu";
            this.Load += new System.EventHandler(this.DodajKnjigu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private BibliotekaDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BibliotekaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.TextBox autorTB;
        private System.Windows.Forms.TextBox naslovTB;
        private System.Windows.Forms.TextBox gradTB;
        private System.Windows.Forms.TextBox godinaTB;
        private System.Windows.Forms.TextBox izdavacTB;
        private System.Windows.Forms.TextBox libIDTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vrednostTB;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}