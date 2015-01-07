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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gelismisaramakutu = new System.Windows.Forms.TextBox();
            this.aramakategori = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.musteribilgileri.Location = new System.Drawing.Point(12, 109);
            this.musteribilgileri.Name = "musteribilgileri";
            this.musteribilgileri.Size = new System.Drawing.Size(960, 375);
            this.musteribilgileri.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(93, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı Arama";
            // 
            // hizliaramakutu
            // 
            this.hizliaramakutu.Location = new System.Drawing.Point(6, 33);
            this.hizliaramakutu.Name = "hizliaramakutu";
            this.hizliaramakutu.Size = new System.Drawing.Size(184, 20);
            this.hizliaramakutu.TabIndex = 5;
            this.hizliaramakutu.Text = "T.C. Kimlik Numarası Giriniz";
         
            this.hizliaramakutu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hizliaramakutu_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.gelismisaramakutu);
            this.groupBox2.Controls.Add(this.aramakategori);
            this.groupBox2.Location = new System.Drawing.Point(540, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelişmiş Arama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gelismisaramakutu
            // 
            this.gelismisaramakutu.Location = new System.Drawing.Point(133, 30);
            this.gelismisaramakutu.Name = "gelismisaramakutu";
            this.gelismisaramakutu.Size = new System.Drawing.Size(120, 20);
            this.gelismisaramakutu.TabIndex = 7;
            // 
            // aramakategori
            // 
            this.aramakategori.FormattingEnabled = true;
            this.aramakategori.Items.AddRange(new object[] {
            "Adınız",
            "Soyadınız",
            "Kayıt Tarihi"});
            this.aramakategori.Location = new System.Drawing.Point(6, 29);
            this.aramakategori.Name = "aramakategori";
            this.aramakategori.Size = new System.Drawing.Size(121, 22);
            this.aramakategori.TabIndex = 6;
            this.aramakategori.Text = "Kategori Seçiniz";
            this.aramakategori.SelectedIndexChanged += new System.EventHandler(this.aramakategori_SelectedIndexChanged);
            // 
            // aramaislmleriformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 497);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView musteribilgileri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hizliaramakutu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox gelismisaramakutu;
        private System.Windows.Forms.ComboBox aramakategori;
        private System.Windows.Forms.ColumnHeader tcno;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader giristarih;
        private System.Windows.Forms.ColumnHeader cikistarihi;
        private System.Windows.Forms.ColumnHeader telefon;
    }
}