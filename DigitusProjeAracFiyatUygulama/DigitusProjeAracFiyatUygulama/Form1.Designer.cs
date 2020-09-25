namespace DigitusProjeAracFiyatUygulama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormalBireyFiyatlandir = new System.Windows.Forms.Button();
            this.btnEngelliBireyFiyatlandir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // btnNormalBireyFiyatlandir
            // 
            this.btnNormalBireyFiyatlandir.Location = new System.Drawing.Point(8, 338);
            this.btnNormalBireyFiyatlandir.Name = "btnNormalBireyFiyatlandir";
            this.btnNormalBireyFiyatlandir.Size = new System.Drawing.Size(164, 114);
            this.btnNormalBireyFiyatlandir.TabIndex = 1;
            this.btnNormalBireyFiyatlandir.Text = "Normal Kullanici Fiyat Listesi için Tıklayınız(Golf 1.3)";
            this.btnNormalBireyFiyatlandir.UseVisualStyleBackColor = true;
            this.btnNormalBireyFiyatlandir.Click += new System.EventHandler(this.btnNormalBireyFiyatlandir_Click);
            // 
            // btnEngelliBireyFiyatlandir
            // 
            this.btnEngelliBireyFiyatlandir.Location = new System.Drawing.Point(614, 338);
            this.btnEngelliBireyFiyatlandir.Name = "btnEngelliBireyFiyatlandir";
            this.btnEngelliBireyFiyatlandir.Size = new System.Drawing.Size(164, 114);
            this.btnEngelliBireyFiyatlandir.TabIndex = 1;
            this.btnEngelliBireyFiyatlandir.Text = "Engelli Birey Fiyat Listesi için Tıklayınız(Golf 1.3)";
            this.btnEngelliBireyFiyatlandir.UseVisualStyleBackColor = true;
            this.btnEngelliBireyFiyatlandir.Click += new System.EventHandler(this.btnEngelliBireyFiyatlandir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 474);
            this.Controls.Add(this.btnEngelliBireyFiyatlandir);
            this.Controls.Add(this.btnNormalBireyFiyatlandir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormalBireyFiyatlandir;
        private System.Windows.Forms.Button btnEngelliBireyFiyatlandir;
    }
}

