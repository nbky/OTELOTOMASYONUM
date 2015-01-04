namespace otel_otomasyon
{
    partial class aramaislmleriformu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aramaislmleriformu));
            this.musteribilgileri = new System.Windows.Forms.ListView();
            this.tcno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giristarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikistarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hizliaramakutu = new System.Windows.Forms.TextBox();
            this.mevcutmusteriyihizliaramabutonu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteribilgileri
            // 
            this.musteribilgileri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.musteribilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tcno,
            this.adsoyad,
            this.giristarih,
            this.cikistarihi,
            this.telefon});
            this.musteribilgileri.Location = new System.Drawing.Point(12, 89);
            this.musteribilgileri.Name = "musteribilgileri";
            this.musteribilgileri.Size = new System.Drawing.Size(960, 395);
            this.musteribilgileri.TabIndex = 3;
            this.musteribilgileri.UseCompatibleStateImageBehavior = false;
            // 
            // tcno
            // 
            this.tcno.Text = "T.C. Kimlik Numarası";
            this.tcno.Width = 100;
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "Adı Soyadı";
            this.adsoyad.Width = 100;
            // 
            // giristarih
            // 
            this.giristarih.Text = "Giriş Tarihi";
            // 
            // cikistarihi
            // 
            this.cikistarihi.Text = "Çıkış Tarihi";
            this.cikistarihi.Width = 100;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon Numarası";
            this.telefon.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hizliaramakutu);
            this.groupBox1.Controls.Add(this.mevcutmusteriyihizliaramabutonu);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Arama";
            // 
            // hizliaramakutu
            // 
            this.hizliaramakutu.Location = new System.Drawing.Point(310, 30);
            this.hizliaramakutu.MaxLength = 11;
            this.hizliaramakutu.Name = "hizliaramakutu";
            this.hizliaramakutu.Size = new System.Drawing.Size(184, 20);
            this.hizliaramakutu.TabIndex = 0;
            this.hizliaramakutu.Text = "T.C. Kimlik Numarası Giriniz";
            this.hizliaramakutu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hizliaramakutu_KeyDown);
            this.hizliaramakutu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hizliaramakutu_MouseDown);
            // 
            // mevcutmusteriyihizliaramabutonu
            // 
            this.mevcutmusteriyihizliaramabutonu.Location = new System.Drawing.Point(545, 30);
            this.mevcutmusteriyihizliaramabutonu.Name = "mevcutmusteriyihizliaramabutonu";
            this.mevcutmusteriyihizliaramabutonu.Size = new System.Drawing.Size(118, 25);
            this.mevcutmusteriyihizliaramabutonu.TabIndex = 1;
            this.mevcutmusteriyihizliaramabutonu.Text = "Ara";
            this.mevcutmusteriyihizliaramabutonu.UseVisualStyleBackColor = true;
            this.mevcutmusteriyihizliaramabutonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // aramaislmleriformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.musteribilgileri);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aramaislmleriformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView musteribilgileri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hizliaramakutu;
        private System.Windows.Forms.Button mevcutmusteriyihizliaramabutonu;
        private System.Windows.Forms.ColumnHeader tcno;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader giristarih;
        private System.Windows.Forms.ColumnHeader cikistarihi;
        private System.Windows.Forms.ColumnHeader telefon;
    }
}