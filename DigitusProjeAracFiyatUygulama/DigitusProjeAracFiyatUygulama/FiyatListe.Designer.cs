namespace DigitusProjeAracFiyatUygulama
{
    partial class FiyatListe
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
            this.txtDosyaYol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTabloGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdExcelListe = new System.Windows.Forms.DataGridView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcelListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Location = new System.Drawing.Point(131, 27);
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.Size = new System.Drawing.Size(376, 22);
            this.txtDosyaYol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Yolu Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(513, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "...";
            //
            // btnTabloGetir
            // 
            this.btnTabloGetir.Location = new System.Drawing.Point(558, 21);
            this.btnTabloGetir.Name = "btnTabloGetir";
            this.btnTabloGetir.Size = new System.Drawing.Size(143, 29);
            this.btnTabloGetir.TabIndex = 3;
            this.btnTabloGetir.Text = "Tabloyu Getir";
            this.btnTabloGetir.UseVisualStyleBackColor = true;
            this.btnTabloGetir.Click += new System.EventHandler(this.btnTabloGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdExcelListe);
            this.groupBox1.Location = new System.Drawing.Point(25, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Listesi";
            // 
            // grdExcelListe
            // 
            this.grdExcelListe.AllowUserToAddRows = false;
            this.grdExcelListe.AllowUserToDeleteRows = false;
            this.grdExcelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExcelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExcelListe.Location = new System.Drawing.Point(3, 18);
            this.grdExcelListe.Name = "grdExcelListe";
            this.grdExcelListe.ReadOnly = false;
            this.grdExcelListe.RowHeadersWidth = 51;
            this.grdExcelListe.RowTemplate.Height = 24;
            this.grdExcelListe.Size = new System.Drawing.Size(670, 331);
            this.grdExcelListe.TabIndex = 0;
            // 
            // FiyatListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTabloGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDosyaYol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FiyatListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiyatListe";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExcelListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDosyaYol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTabloGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdExcelListe;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}