using KependudukanApp;
using System;
using System.Windows.Forms;

namespace Kependudukan
{
    public partial class Login_frm : Form
    {
        private Login_cls user;

        public Login_frm(DataPenduduk dataPenduduk)
        {
            InitializeComponent();
            user = new Login_cls();
        }

        public Login_frm()
        {
            InitializeComponent();
            user = new Login_cls();
        }

        private void Exit_login_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = Id_user_tb.Text.Trim();
            string password = pass_tb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Isi username sama password dulu, yaa! >_<", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user.CekLogin(username, password))
            {
                MessageBox.Show("Login sukses, yeay! >_<", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                DataPenduduk dashboard = new DataPenduduk();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah, coba lagi yaa! >_<", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Id_user_tb.Text = "";
                pass_tb.Text = "";
                Id_user_tb.Focus();
            }
        }

        private void Id_user_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pass_tb.Focus();
            }
        }

        private void pass_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login_btn.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}