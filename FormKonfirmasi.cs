using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormKonfirmasi : Form
    {
        public FormKonfirmasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2cnfrm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBox1.Focus();
            if (textBox1.TextLength == 0)
            {
                errorProvider1.SetError(textBox1,"Kode Konfirmasi tidak boleh kosong");
                textBox1.Focus();
            }
            else {
                MessageBox.Show("Kode Konfirmasi diterima Silahkan ganti password Anda untuk keamanan");
                linkLabelGotoChange.Visible = true;
            }

        }

        private void FormKonfirmasi_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelGotoChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormChangePass gnti = new FormChangePass();
            gnti.Show();
        }
    }
}
