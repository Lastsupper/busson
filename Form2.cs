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
    public partial class FormLupa : Form
    {
        public FormLupa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void labelKode_Click(object sender, EventArgs e)
        {
          
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            textBoxUsernameF.Focus();
            if (textBoxUsernameF.TextLength == 0) {
                errorProvider2.SetError(textBoxUsernameF, "Username tidak boleh kosong");
                textBoxUsernameF.Focus();
            }
            else if (noHpF.TextLength == 0 )
            {
                errorProvider2.SetError(noHpF, "Silahkan masukkan nomor Hp anda");
                noHpF.Focus();
            }
            else if (noHpF.TextLength <= 10 || noHpF.TextLength >=13)
            {
                errorProvider2.SetError(noHpF, "Nomor Hp yang anda masukkan salah");
                noHpF.Focus();
            }
            else {
                MessageBox.Show("kode konfirmasi telah dikirimkan ke no HP anda , silahkan konfirmasikan kode");
                linkLabelForgot.Visible = true;
            }

        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormKonfirmasi knfrm = new FormKonfirmasi();
            knfrm.Show();
        }

        private void buttonResetForgot_Click(object sender, EventArgs e)
        {
            textBoxUsernameF.ResetText();
            noHpF.ResetText();
            textBoxUsernameF.Focus();
            linkLabelForgot.Visible = false;
        }

        private void noHpF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 || (Keys)e.KeyChar == Keys.Back))
                e.KeyChar = (char)Keys.None;
        }
    }
}
