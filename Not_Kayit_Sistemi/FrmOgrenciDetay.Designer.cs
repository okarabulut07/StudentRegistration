﻿namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSinav1 = new System.Windows.Forms.Label();
            this.lblSinav2 = new System.Windows.Forms.Label();
            this.lblSinav3 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 1:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 3:";
            // 
            // lblSinav1
            // 
            this.lblSinav1.AutoSize = true;
            this.lblSinav1.Location = new System.Drawing.Point(111, 116);
            this.lblSinav1.Name = "lblSinav1";
            this.lblSinav1.Size = new System.Drawing.Size(28, 18);
            this.lblSinav1.TabIndex = 5;
            this.lblSinav1.Text = "00";
            // 
            // lblSinav2
            // 
            this.lblSinav2.AutoSize = true;
            this.lblSinav2.Location = new System.Drawing.Point(111, 145);
            this.lblSinav2.Name = "lblSinav2";
            this.lblSinav2.Size = new System.Drawing.Size(28, 18);
            this.lblSinav2.TabIndex = 6;
            this.lblSinav2.Text = "00";
            // 
            // lblSinav3
            // 
            this.lblSinav3.AutoSize = true;
            this.lblSinav3.Location = new System.Drawing.Point(111, 174);
            this.lblSinav3.Name = "lblSinav3";
            this.lblSinav3.Size = new System.Drawing.Size(28, 18);
            this.lblSinav3.TabIndex = 7;
            this.lblSinav3.Text = "00";
            this.lblSinav3.Click += new System.EventHandler(this.Label8_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(107, 28);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(52, 18);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = "NULL";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(98, 64);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(48, 18);
            this.lblNumara.TabIndex = 9;
            this.lblNumara.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ortalama:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(111, 217);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(28, 18);
            this.lblOrtalama.TabIndex = 11;
            this.lblOrtalama.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Durum:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(111, 257);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 18);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(403, 284);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblSinav3);
            this.Controls.Add(this.lblSinav2);
            this.Controls.Add(this.lblSinav1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciDetay";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.FrmOgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSinav1;
        private System.Windows.Forms.Label lblSinav2;
        private System.Windows.Forms.Label lblSinav3;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDurum;
    }
}