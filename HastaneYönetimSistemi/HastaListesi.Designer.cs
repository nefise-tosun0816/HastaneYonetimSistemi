﻿namespace HastaneYönetimSistemi
{
    partial class HastaListesi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugünün Hasta Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Muayene işlemi için listeden hasta bilgileri üzerine çift tıklayınız.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hastayı Çağır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hastaları Göster";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 87);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaListesi";
            this.Text = "HastaListesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}