using KependudukanApp;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kependudukan
{
    public partial class FormEditPenduduk : Form
    {
        private Database db;
        private DataPenduduk form1;

        public FormEditPenduduk(DataPenduduk parentForm)
        {
            InitializeComponent();
            db = new Database();
            form1 = parentForm;
            InitializeComboBoxes();
            DisableEditFields();
        }

        private void InitializeComboBoxes()
        {
            cbJenisKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            cbJenisKelamin.SelectedIndex = 0;

            cbAgama.Items.AddRange(new string[] { "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu", "Yahudi" });
            cbAgama.SelectedIndex = 0;

            cbStatusPerkawinan.Items.AddRange(new string[] { "Belum Menikah", "Menikah", "Cerai" });
            cbStatusPerkawinan.SelectedIndex = 0;

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
        }

        private void DisableEditFields()
        {
            txtNIK.Enabled = false;
            txtNama.Enabled = false;
            dtpTanggalLahir.Enabled = false;
            cbJenisKelamin.Enabled = false;
            cbIdKelurahan.Enabled = false;
            txtPekerjaan.Enabled = false;
            cbStatusPerkawinan.Enabled = false;
            cbAgama.Enabled = false;
            btnSimpan.Enabled = false;
        }

        private void EnableEditFields()
        {
            txtNama.Enabled = true;
            dtpTanggalLahir.Enabled = true;
            cbJenisKelamin.Enabled = true;
            cbIdKelurahan.Enabled = true;
            txtPekerjaan.Enabled = true;
            cbStatusPerkawinan.Enabled = true;
            cbAgama.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string input = txtCari.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Isi dulu NIK atau Nama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();
                string query = "SELECT NIK, Nama, TanggalLahir, JenisKelamin, IdKelurahan, pekerjaan, status, agama " +
                               "FROM Penduduk WHERE NIK = @Input OR Nama = @Input";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Input", input);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNIK.Text = reader["NIK"].ToString();
                    txtNama.Text = reader["Nama"].ToString();
                    dtpTanggalLahir.Value = DateTime.Parse(reader["TanggalLahir"].ToString());
                    cbJenisKelamin.SelectedItem = reader["JenisKelamin"].ToString();
                    cbIdKelurahan.SelectedValue = reader["IdKelurahan"];
                    txtPekerjaan.Text = reader["pekerjaan"].ToString();
                    cbStatusPerkawinan.SelectedItem = reader["status"].ToString();
                    cbAgama.SelectedItem = reader["agama"].ToString();
                    labelInfo.Text = "Data ditemukan, silakan edit! >_<";
                    EnableEditFields();
                }
                else
                {
                    labelInfo.Text = "Data ga ketemu, coba lagi :)";
                    DisableEditFields();
                    ClearFields();
                }
                reader.Close();
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cek data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtNIK.Text = "";
            txtNama.Text = "";
            dtpTanggalLahir.Value = DateTime.Now;
            cbJenisKelamin.SelectedIndex = 0;
            cbIdKelurahan.SelectedIndex = 0;
            txtPekerjaan.Text = "";
            cbStatusPerkawinan.SelectedIndex = 0;
            cbAgama.SelectedIndex = 0;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nik = txtNIK.Text.Trim();
            if (string.IsNullOrEmpty(nik))
            {
                MessageBox.Show("Data belum dicek, cek dulu ya! >_<", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi perubahan
            DialogResult result = MessageBox.Show($"Yakin mau simpan perubahan untuk NIK: {nik}?", "Konfirmasi Simpan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                db.OpenConnection();
                string query = "UPDATE Penduduk SET Nama = @Nama, TanggalLahir = @TanggalLahir, JenisKelamin = @JenisKelamin, " +
                               "IdKelurahan = @IdKelurahan, pekerjaan = @Pekerjaan, status = @StatusPerkawinan, agama = @Agama " +
                               "WHERE NIK = @NIK";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@NIK", nik);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@JenisKelamin", cbJenisKelamin.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@IdKelurahan", (cbIdKelurahan.SelectedItem as dynamic).Id);
                cmd.Parameters.AddWithValue("@Pekerjaan", txtPekerjaan.Text);
                cmd.Parameters.AddWithValue("@StatusPerkawinan", cbStatusPerkawinan.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Agama", cbAgama.SelectedItem.ToString());
                int rowsAffected = cmd.ExecuteNonQuery();
                db.CloseConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data penduduk diupdate, yay! >_<", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form1.LoadDataPenduduk(); // Refresh Form1
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ga ada perubahan atau data ga ketemu :(", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan perubahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}