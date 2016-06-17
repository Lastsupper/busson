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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBox1.Focus();
            if (textBox1.TextLength == 0)
            {
                errorProvider1.SetError(textBox1, "Username tidak boleh kosong");
                textBox1.Focus();
            }
            else if (textBox1.TextLength <= 5 || textBox1.TextLength >= 13)
            {
                errorProvider1.SetError(textBox1, "Harus 6 - 12 digit");
                textBox1.Focus();
            }
            else if (textBox2Login.TextLength == 0)
            {
                errorProvider1.SetError(textBox2Login, "Password tidak boleh kosong");
                textBox2Login.Focus();
            }
            else
            {
                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLupa lupa = new FormLupa();
            lupa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
