namespace Kutuphane.UI
{
    partial class HesabimForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvOduncAlinanKitap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapTeslimEt = new System.Windows.Forms.Button();
            this.dtpSonTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinanKitap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(108, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(108, 54);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 16);
            this.lblAdSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad Soyad";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(108, 79);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 16);
            this.lblKullaniciAdi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(108, 107);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(0, 16);
            this.lblParola.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Parola";
            // 
            // dgvOduncAlinanKitap
            // 
            this.dgvOduncAlinanKitap.AllowUserToAddRows = false;
            this.dgvOduncAlinanKitap.AllowUserToDeleteRows = false;
            this.dgvOduncAlinanKitap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOduncAlinanKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOduncAlinanKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOduncAlinanKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncAlinanKitap.Location = new System.Drawing.Point(6, 30);
            this.dgvOduncAlinanKitap.MultiSelect = false;
            this.dgvOduncAlinanKitap.Name = "dgvOduncAlinanKitap";
            this.dgvOduncAlinanKitap.ReadOnly = true;
            this.dgvOduncAlinanKitap.RowHeadersVisible = false;
            this.dgvOduncAlinanKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOduncAlinanKitap.Size = new System.Drawing.Size(573, 206);
            this.dgvOduncAlinanKitap.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 271);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgiler";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(209, 237);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Bilgilerimi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnKitapTeslimEt);
            this.groupBox2.Controls.Add(this.dtpSonTeslimTarihi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvOduncAlinanKitap);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 271);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Alınan Kitaplar";
            // 
            // btnKitapTeslimEt
            // 
            this.btnKitapTeslimEt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitapTeslimEt.Location = new System.Drawing.Point(463, 242);
            this.btnKitapTeslimEt.Name = "btnKitapTeslimEt";
            this.btnKitapTeslimEt.Size = new System.Drawing.Size(100, 23);
            this.btnKitapTeslimEt.TabIndex = 11;
            this.btnKitapTeslimEt.Text = "Kitap Teslim Et";
            this.btnKitapTeslimEt.UseVisualStyleBackColor = true;
            this.btnKitapTeslimEt.Click += new System.EventHandler(this.btnKitapTeslimEt_Click);
            // 
            // dtpSonTeslimTarihi
            // 
            this.dtpSonTeslimTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSonTeslimTarihi.Location = new System.Drawing.Point(302, 243);
            this.dtpSonTeslimTarihi.Name = "dtpSonTeslimTarihi";
            this.dtpSonTeslimTarihi.Size = new System.Drawing.Size(155, 20);
            this.dtpSonTeslimTarihi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Son Teslim Tarihi";
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HesabimForm";
            this.Text = "HesabimForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinanKitap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvOduncAlinanKitap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapTeslimEt;
        private System.Windows.Forms.DateTimePicker dtpSonTeslimTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
    }
}