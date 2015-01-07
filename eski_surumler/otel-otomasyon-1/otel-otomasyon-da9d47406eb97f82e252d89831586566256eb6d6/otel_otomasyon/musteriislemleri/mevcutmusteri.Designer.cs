namespace otel_otomasyon
{
    partial class mevcutmusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mevcutmusteri));
            this.musteribilgiformu = new System.Windows.Forms.ListView();
            this.tckimlikno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giristarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikistarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteribilgiarama = new System.Windows.Forms.Button();
            this.musteribilgiyazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteribilgiformu
            // 
            this.musteribilgiformu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tckimlikno,
            this.adsoyad,
            this.giristarih,
            this.cikistarihi,
            this.odano,
            this.telefonno});
            this.musteribilgiformu.Location = new System.Drawing.Point(12, 25);
            this.musteribilgiformu.Name = "musteribilgiformu";
            this.musteribilgiformu.Size = new System.Drawing.Size(960, 424);
            this.musteribilgiformu.TabIndex = 0;
            this.musteribilgiformu.UseCompatibleStateImageBehavior = false;
            // 
            // tckimlikno
            // 
            this.tckimlikno.Text = "T.C. Kimlik Numarası";
            this.tckimlikno.Width = 150;
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "Adı Soyadı";
            this.adsoyad.Width = 100;
            // 
            // giristarih
            // 
            this.giristarih.Text = "Giriş Tarihi";
            this.giristarih.Width = 150;
            // 
            // cikistarihi
            // 
            this.cikistarihi.Text = "Çıkış Tarihi";
            this.cikistarihi.Width = 150;
            // 
            // odano
            // 
            this.odano.Text = "Oda Numarası";
            this.odano.Width = 50;
            // 
            // telefonno
            // 
            this.telefonno.Text = "Telefon Numarası";
            this.telefonno.Width = 100;
            // 
            // musteribilgiarama
            // 
            this.musteribilgiarama.Location = new System.Drawing.Point(389, 455);
            this.musteribilgiarama.Name = "musteribilgiarama";
            this.musteribilgiarama.Size = new System.Drawing.Size(90, 29);
            this.musteribilgiarama.TabIndex = 1;
            this.musteribilgiarama.Text = "Arama";
            this.musteribilgiarama.UseVisualStyleBackColor = true;
            // 
            // musteribilgiyazdir
            // 
            this.musteribilgiyazdir.Location = new System.Drawing.Point(487, 455);
            this.musteribilgiyazdir.Name = "musteribilgiyazdir";
            this.musteribilgiyazdir.Size = new System.Drawing.Size(90, 29);
            this.musteribilgiyazdir.TabIndex = 2;
            this.musteribilgiyazdir.Text = "Yazdır";
            this.musteribilgiyazdir.UseVisualStyleBackColor = true;
            // 
            // mevcutmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.musteribilgiyazdir);
            this.Controls.Add(this.musteribilgiarama);
            this.Controls.Add(this.musteribilgiformu);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mevcutmusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView musteribilgiformu;
        private System.Windows.Forms.ColumnHeader tckimlikno;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader giristarih;
        private System.Windows.Forms.ColumnHeader cikistarihi;
        private System.Windows.Forms.ColumnHeader odano;
        private System.Windows.Forms.ColumnHeader telefonno;
        private System.Windows.Forms.Button musteribilgiarama;
        private System.Windows.Forms.Button musteribilgiyazdir;


    }
}