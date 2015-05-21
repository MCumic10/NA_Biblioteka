namespace NA_Biblioteka
{
    partial class IzmeniKnjigu
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
            System.Windows.Forms.Label izdavacLabel;
            System.Windows.Forms.Label godinaLabel;
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label naslovLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniKnjigu));
            this.button1 = new System.Windows.Forms.Button();
            this.izdavacTB = new System.Windows.Forms.TextBox();
            this.godinaTB = new System.Windows.Forms.TextBox();
            this.gradTB = new System.Windows.Forms.TextBox();
            this.naslovTB = new System.Windows.Forms.TextBox();
            this.autorTB = new System.Windows.Forms.TextBox();
            this.bibliotekaDataSet = new NA_Biblioteka.BibliotekaDataSet();
            this.korisnikTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.KorisnikTableAdapter();
            this.knjigaTableAdapter = new NA_Biblioteka.BibliotekaDataSetTableAdapters.KnjigaTableAdapter();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NA_Biblioteka.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            izdavacLabel = new System.Windows.Forms.Label();
            godinaLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            naslovLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // izdavacLabel
            // 
            izdavacLabel.AutoSize = true;
            izdavacLabel.Location = new System.Drawing.Point(19, 153);
            izdavacLabel.Name = "izdavacLabel";
            izdavacLabel.Size = new System.Drawing.Size(48, 13);
            izdavacLabel.TabIndex = 22;
            izdavacLabel.Text = "Izdavac:";
            // 
            // godinaLabel
            // 
            godinaLabel.AutoSize = true;
            godinaLabel.Location = new System.Drawing.Point(23, 117);
            godinaLabel.Name = "godinaLabel";
            godinaLabel.Size = new System.Drawing.Size(44, 13);
            godinaLabel.TabIndex = 20;
            godinaLabel.Text = "Godina:";
            // 
            // gradLabel
            // 
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(34, 81);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(33, 13);
            gradLabel.TabIndex = 17;
            gradLabel.Text = "Grad:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new System.Drawing.Point(24, 45);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(43, 13);
            naslovLabel.TabIndex = 14;
            naslovLabel.Text = "Naslov:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(32, 9);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 11;
            autorLabel.Text = "Autor:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // izdavacTB
            // 
            this.izdavacTB.Location = new System.Drawing.Point(73, 150);
            this.izdavacTB.Name = "izdavacTB";
            this.izdavacTB.Size = new System.Drawing.Size(100, 20);
            this.izdavacTB.TabIndex = 18;
            // 
            // godinaTB
            // 
            this.godinaTB.Location = new System.Drawing.Point(73, 114);
            this.godinaTB.Name = "godinaTB";
            this.godinaTB.Size = new System.Drawing.Size(100, 20);
            this.godinaTB.TabIndex = 16;
            // 
            // gradTB
            // 
            this.gradTB.Location = new System.Drawing.Point(73, 78);
            this.gradTB.Name = "gradTB";
            this.gradTB.Size = new System.Drawing.Size(100, 20);
            this.gradTB.TabIndex = 15;
            // 
            // naslovTB
            // 
            this.naslovTB.Location = new System.Drawing.Point(73, 42);
            this.naslovTB.Name = "naslovTB";
            this.naslovTB.Size = new System.Drawing.Size(100, 20);
            this.naslovTB.TabIndex = 13;
            // 
            // autorTB
            // 
            this.autorTB.Location = new System.Drawing.Point(73, 6);
            this.autorTB.Name = "autorTB";
            this.autorTB.Size = new System.Drawing.Size(100, 20);
            this.autorTB.TabIndex = 12;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.bibliotekaDataSet;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 187);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 20;
            label1.Text = "LibID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 22;
            label2.Text = "Vrednost:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // IzmeniKnjigu
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.izdavacTB);
            this.Controls.Add(this.godinaTB);
            this.Controls.Add(this.gradTB);
            this.Controls.Add(this.naslovTB);
            this.Controls.Add(label2);
            this.Controls.Add(this.autorTB);
            this.Controls.Add(label1);
            this.Controls.Add(izdavacLabel);
            this.Controls.Add(godinaLabel);
            this.Controls.Add(gradLabel);
            this.Controls.Add(naslovLabel);
            this.Controls.Add(autorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IzmeniKnjigu";
            this.Text = "IzmeniKnjigu";
            this.Load += new System.EventHandler(this.IzmeniKnjigu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox izdavacTB;
        private System.Windows.Forms.TextBox godinaTB;
        private System.Windows.Forms.TextBox gradTB;
        private System.Windows.Forms.TextBox naslovTB;
        private System.Windows.Forms.TextBox autorTB;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private BibliotekaDataSet bibliotekaDataSet;
        private BibliotekaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BibliotekaDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}