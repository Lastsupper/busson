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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Tanggal";
            comboBox2.Text = "Tahun";
            comboBox3.Text = "Bulan";
        }

        private void buttonDaftarAkun_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            textBox1.Focus();
            if (textBox1.TextLength == 0) {
                errorProvider1.SetError(textBox1, "Nama tidak boleh kosong");
                textBox1.Focus();
            }
            else if (textBox2.TextLength == 0)
            {
                errorProvider1.SetError(textBox2, "Masukkan no hp anda");
                textBox2.Focus();
            }
            else if (textBox2.TextLength <= 10 || textBox2.TextLength >= 13)
            {
                errorProvider1.SetError(textBox2, "no hp yang anda masukkan salah");
                textBox2.Focus();
            }
            else if (textBoxUsername.TextLength == 0)
            {
                errorProvider1.SetError(textBoxUsername, "Username tidak boleh kosong");
                textBoxUsername.Focus();
            }
            else if (textBoxPassword.TextLength == 0)
            {
                errorProvider1.SetError(textBoxPassword, "Password tidak boleh kosong");
                textBoxPassword.Focus();
            }
            else if (textBoxPassword2.TextLength == 0)
            {
                errorProvider1.SetError(textBoxPassword2, "Password tidak boleh kosong");
                textBoxPassword2.Focus();
            }
            else if (textBoxPassword.Text != textBoxPassword2.Text)
            {
                errorProvider1.SetError(textBoxPassword2, "Password tidak cocok");
                textBoxPassword2.Focus();
            }
            else if (comboBox1.SelectedIndex == 0) {
                errorProvider1.SetError(comboBox1, "Pilih tanggal lahir");
                comboBox1.Focus();
            }
            else if (comboBox3.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox3, "Pilih tanggal lahir");
                comboBox3.Focus();
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox2, "Pilih tahun lahir");
                comboBox2.Focus();
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorProvider1.SetError(radioButton2, "Silahkan Pilih Jenis Kelamin anda");
                radioButton1.Focus();
            }
            else
            {
                MessageBox.Show("Akun anda berhasil dibuat , Silahkan login untuk melanjutkan");
                linkLabel1Reg.Visible = true;
            }
            

        }

        private void linkLabel1Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBoxPassword.ResetText();
            textBoxPassword2.ResetText();
            textBoxUsername.ResetText();
            textBox1.Focus();
            linkLabel1Reg.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back))
                e.KeyChar = (char)Keys.None;

        }
    }
}
