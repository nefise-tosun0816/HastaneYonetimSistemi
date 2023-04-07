﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimSistemi
{
    public partial class DoktorGirişSayfası : Form
    {
        public DoktorGirişSayfası()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // yeni formu ekranın ortasında aç
            this.TopMost = true; // yeni formu en üstte göster
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Anasayfa form1 = new Anasayfa();
                form1.Show();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Doktor Doktor = new Doktor();
            Doktor.Show();
            this.Hide();
        }
    }
}
