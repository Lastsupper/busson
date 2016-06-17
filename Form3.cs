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
    public partial class FormChangePass : Form
    {
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider3.Clear();
            textBox1Set.Focus();
            if (textBox1Set.TextLength == 0) {
                errorProvider3.SetError(textBox1Set, "Password tidak boleh kosong");
                textBox1Set.Focus();
            }
            else if (textBox2Set.TextLength == 0)
            {
                errorProvider3.SetError(textBox2Set, "Password tidak boleh kosong");
                textBox2Set.Focus();
            }
            else if (textBox3Set.TextLength == 0)
            {
                errorProvider3.SetError(textBox3Set, "Password tidak boleh kosong");
                textBox3Set.Focus();
            }
            else if (textBox3Set.Text != textBox2Set.Text) {
                errorProvider3.SetError(textBox3Set, "Password tidak cocok");
                textBox3Set.Focus();
            }
            else if (textBox4Set.TextLength == 0)
            {
                errorProvider3.SetError(textBox4Set, "No Hp tidak boleh kosong");
                textBox4Set.Focus();
            }
            else if (textBox4Set.TextLength <= 10 || textBox4Set.TextLength >= 13)
            {
                errorProvider3.SetError(textBox4Set, "No Hp tidak boleh kosong");
                textBox4Set.Focus();
            }
            else
            {
                MessageBox.Show("Password berhasil diganti");
                linkLabelSetPass.Visible = true;
            }

        }

        private void linkLabelSetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider3.Clear();
            textBox1Set.ResetText();
            textBox2Set.ResetText();
            textBox3Set.ResetText();
            textBox4Set.ResetText();
            textBox1Set.Focus();
            linkLabelSetPass.Visible = false;
        }

        private void textBox4Set_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4Set_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back))
                e.KeyChar = (char)Keys.None;
        }
    }
}
