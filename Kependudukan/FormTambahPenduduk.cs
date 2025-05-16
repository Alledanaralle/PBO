using KependudukanApp;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kependudukan
{
    public partial class FormTambahPenduduk : Form
    {
        private Database db;

        public FormTambahPenduduk()
        {
            InitializeComponent();
            db = new Database();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Isi ComboBox Jenis Kelamin
            cbJenisKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            cbJenisKelamin.SelectedIndex = 0;

            // Isi ComboBox Agama
            txtAgama.Items.AddRange(new string[] { "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu", "Yahudi" });
            txtAgama.SelectedIndex = 0;

            // Isi ComboBox Status Perkawinan
            cbStatusPerkawinan.Items.AddRange(new string[] { "Belum Menikah", "Menikah", "Cerai" });
            cbStatusPerkawinan.SelectedIndex = 0;

            // Isi ComboBox IdKelurahan dari table Kelurahan
            try
            {
                db.OpenConnection();
                string query = "SELECT IdKelurahan, NamaKelurahan FROM Kelurahan";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbIdKelurahan.Items.Add(new { Id = reader["IdKelurahan"], Name = reader["NamaKelurahan"] });
                }
                reader.Close();
                db.CloseConnection();
                cbIdKelurahan.DisplayMember = "Name";
                cbIdKelurahan.ValueMember = "Id";
                cbIdKelurahan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load kelurahan: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                db.OpenConnection();
                string query = "SELECT IdKecamatan, NamaKecamatan FROM kecamatan";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbIdKecamatan.Items.Add(new { Id = reader["IdKecamatan"], Name = reader["NamaKecamatan"] });
                }
                reader.Close();
                db.CloseConnection();
                cbIdKecamatan.DisplayMember = "Name";
                cbIdKecamatan.ValueMember = "Id";
                cbIdKecamatan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load kecamatan: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                db.OpenConnection();
                string query = "SELECT IdKabupaten, NamaKabupaten FROM kabupaten";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbIdKabupaten.Items.Add(new { Id = reader["IdKabupaten"], Name = reader["NamaKabupaten"] });
                }
                reader.Close();
                db.CloseConnection();
                cbIdKabupaten.DisplayMember = "Name";
                cbIdKabupaten.ValueMember = "Id";
                cbIdKabupaten.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load kabupaten: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(txtNIK.Text) || txtNIK.Text.Length != 16)
            {
                MessageBox.Show("NIK harus 16 digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama ga boleh kosong, ya!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAgama.Text))
            {
                MessageBox.Show("Agama ga boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();
                string query = "INSERT INTO Penduduk (NIK, Nama, TanggalLahir, JenisKelamin, IdKelurahan, pekerjaan, status, agama, IdKecamatan, IdKabupaten) " +
                              "VALUES (@NIK, @Nama, @TanggalLahir, @JenisKelamin, @IdKelurahan, @pekerjaan, @status, @agama, @IdKecamatan, @IdKabupaten)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@NIK", txtNIK.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@JenisKelamin", cbJenisKelamin.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@IdKelurahan", (cbIdKelurahan.SelectedItem as dynamic).Id);
                cmd.Parameters.AddWithValue("@pekerjaan", txtPekerjaan.Text);
                cmd.Parameters.AddWithValue("@status", cbStatusPerkawinan.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@agama", txtAgama.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@IdKecamatan", (cbIdKecamatan.SelectedItem as dynamic).Id);
                cmd.Parameters.AddWithValue("@IdKabupaten", (cbIdKabupaten.SelectedItem as dynamic).Id);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Data penduduk tersimpan, yay! >_<", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Tutup form setelah simpan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan data: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.Dispose(); // Pastikan form di-dispose beneran
        }

       
    }
}