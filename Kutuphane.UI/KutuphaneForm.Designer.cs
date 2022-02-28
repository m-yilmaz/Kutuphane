namespace Kutuphane.UI
{
    partial class KutuphaneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapBağışlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitapImha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tsmKaydet = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama: ";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(297, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(148, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // cboTurler
            // 
            this.cboTurler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(667, 27);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(121, 21);
            this.cboTurler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türler";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(13, 54);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(775, 394);
            this.dgvKitaplar.TabIndex = 4;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHesabim,
            this.tsmBagisYap,
            this.tsmCikisYap,
            this.tsmKaydet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmHesabim
            // 
            this.tsmHesabim.Name = "tsmHesabim";
            this.tsmHesabim.Size = new System.Drawing.Size(66, 20);
            this.tsmHesabim.Text = "Hesabım";
            this.tsmHesabim.Click += new System.EventHandler(this.tsmHesabim_Click);
            // 
            // tsmBagisYap
            // 
            this.tsmBagisYap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapBağışlaToolStripMenuItem});
            this.tsmBagisYap.Name = "tsmBagisYap";
            this.tsmBagisYap.Size = new System.Drawing.Size(69, 20);
            this.tsmBagisYap.Text = "Bağış Yap";
            this.tsmBagisYap.Click += new System.EventHandler(this.tsmBagisYap_Click);
            // 
            // kitapBağışlaToolStripMenuItem
            // 
            this.kitapBağışlaToolStripMenuItem.Name = "kitapBağışlaToolStripMenuItem";
            this.kitapBağışlaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kitapBağışlaToolStripMenuItem.Text = "Kitap Bağışla";
            // 
            // tsmCikisYap
            // 
            this.tsmCikisYap.Name = "tsmCikisYap";
            this.tsmCikisYap.Size = new System.Drawing.Size(66, 20);
            this.tsmCikisYap.Text = "Çıkış Yap";
            this.tsmCikisYap.Click += new System.EventHandler(this.tsmCikisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kütüphane";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapAl,
            this.tsmiKitapImha});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // tsmiKitapAl
            // 
            this.tsmiKitapAl.Name = "tsmiKitapAl";
            this.tsmiKitapAl.Size = new System.Drawing.Size(154, 22);
            this.tsmiKitapAl.Text = "Kitap Ödünç Al";
            this.tsmiKitapAl.Click += new System.EventHandler(this.tsmiKitapAl_Click);
            // 
            // tsmiKitapImha
            // 
            this.tsmiKitapImha.Name = "tsmiKitapImha";
            this.tsmiKitapImha.Size = new System.Drawing.Size(154, 22);
            this.tsmiKitapImha.Text = "Kitap İmha Et";
            this.tsmiKitapImha.Click += new System.EventHandler(this.tsmiKitapImha_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(451, 27);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tsmKaydet
            // 
            this.tsmKaydet.Name = "tsmKaydet";
            this.tsmKaydet.Size = new System.Drawing.Size(93, 20);
            this.tsmKaydet.Text = "Verileri Kaydet";
            this.tsmKaydet.Click += new System.EventHandler(this.tsmKaydet_Click);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTurler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KutuphaneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmCikisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem kitapBağışlaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapImha;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ToolStripMenuItem tsmKaydet;
    }
}