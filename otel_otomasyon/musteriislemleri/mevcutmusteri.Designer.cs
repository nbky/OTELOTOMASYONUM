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
            this.musteribilgiarama = new System.Windows.Forms.Button();
            this.musteribilgiyazdir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteribilgiformu
            // 
            this.musteribilgiformu.Location = new System.Drawing.Point(12, 25);
            this.musteribilgiformu.Name = "musteribilgiformu";
            this.musteribilgiformu.Size = new System.Drawing.Size(960, 424);
            this.musteribilgiformu.TabIndex = 0;
            this.musteribilgiformu.UseCompatibleStateImageBehavior = false;
            this.musteribilgiformu.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oda Boşalt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mevcutmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.mevcutmusteri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musteribilgiarama;
        private System.Windows.Forms.Button musteribilgiyazdir;
        public System.Windows.Forms.ListView musteribilgiformu;
        private System.Windows.Forms.Button button1;


    }
}