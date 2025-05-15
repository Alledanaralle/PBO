using KependudukanApp;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kependudukan
{
    public partial class FormHapusPenduduk : Form
    {
        private Database db;
        private DataPenduduk form1;

        public FormHapusPenduduk(DataPenduduk parentForm)
        {
            InitializeComponent();
            db = new Database();
            form1 = parentForm; // Simpen referensi ke Form1 buat refresh
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string input = txtCari.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Isi dulu NIK atau Nama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi hapus
            DialogResult result = MessageBox.Show($"Yakin mau hapus data dengan NIK/Nama: {input}?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                db.OpenConnection();
                string query = "DELETE FROM Penduduk WHERE NIK = @NIK OR Nama = @Nama";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@NIK", input);
                cmd.Parameters.AddWithValue("@Nama", input);
                int rowsAffected = cmd.ExecuteNonQuery();
                db.CloseConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data penduduk dihapus, bye-bye! >_<", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form1.LoadDataPenduduk(); // Refresh Form1
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data ga ketemu, coba cek lagi NIK/Nama-nya!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}