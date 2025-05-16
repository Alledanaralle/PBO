using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KependudukanApp; // Pastikan namespace untuk ConnectionDB_cls benar

namespace Kependudukan
{
    public partial class FromKK : Form
    {
        KartuKeluarga_cls kartukeluarga = new KartuKeluarga_cls();
        Database DBServer; // Tambahkan instance untuk koneksi database

        public FromKK()
        {
            InitializeComponent();
            DBServer = new Database(); // Inisialisasi DBServer
        }

        private void FromKK_Load(object sender, EventArgs e)
        {
            
            tampilGrid();
            isiComboBoxNIK(); // Panggil method untuk mengisi ComboBox
            bersihkan();
        }

        void bersihkan()
        {
            NoKK_txt.Text = ""; 
            Alamat_txt.Text = "";
            id_cmb.SelectedIndex = -1;
            kelurahan_cmb.SelectedIndex = -1;
            kabupaten_cmb.SelectedIndex = -1;
            kecamatan_cmb.SelectedIndex = -1;
            NoKK_txt.Text = kartukeluarga.generateAutoNoKK();
            NoKK_txt.Focus();
        }

        void tampilGrid()
        {
            if (pencarian_txt.Text.Length == 0)
            {
                kartukeluarga_dgv.DataSource = kartukeluarga.tampilSemua();
            }
            else
            {
                kartukeluarga_dgv.DataSource = kartukeluarga.tampilDgNo(pencarian_txt.Text);

            }
          
        }


        void isiComboBoxNIK()
        {
            try
            {
                DBServer.OpenConnection();

                // Isi ComboBox Kabupaten
                string queryKabupaten = "SELECT IdKabupaten, NamaKabupaten FROM kabupaten";
                MySqlCommand cmdKabupaten = new MySqlCommand(queryKabupaten, DBServer.GetConnection());
                MySqlDataAdapter adapterKabupaten = new MySqlDataAdapter(cmdKabupaten);
                DataTable dtKabupaten = new DataTable();
                adapterKabupaten.Fill(dtKabupaten);
                kabupaten_cmb.DataSource = dtKabupaten;
                kabupaten_cmb.DisplayMember = "NamaKabupaten";
                kabupaten_cmb.ValueMember = "IdKabupaten";
                kabupaten_cmb.SelectedIndex = -1;

                // Isi ComboBox Kecamatan
                string queryKecamatan = "SELECT IdKecamatan, NamaKecamatan FROM kecamatan";
                MySqlCommand cmdKecamatan = new MySqlCommand(queryKecamatan, DBServer.GetConnection());
                MySqlDataAdapter adapterKecamatan = new MySqlDataAdapter(cmdKecamatan);
                DataTable dtKecamatan = new DataTable();
                adapterKecamatan.Fill(dtKecamatan);
                kecamatan_cmb.DataSource = dtKecamatan;
                kecamatan_cmb.DisplayMember = "NamaKecamatan";
                kecamatan_cmb.ValueMember = "IdKecamatan";
                kecamatan_cmb.SelectedIndex = -1;

                // Isi ComboBox Kelurahan
                string queryKelurahan = "SELECT IdKelurahan, NamaKelurahan FROM kelurahan";
                MySqlCommand cmdKelurahan = new MySqlCommand(queryKelurahan, DBServer.GetConnection());
                MySqlDataAdapter adapterKelurahan = new MySqlDataAdapter(cmdKelurahan);
                DataTable dtKelurahan = new DataTable();
                adapterKelurahan.Fill(dtKelurahan);
                kelurahan_cmb.DataSource = dtKelurahan;
                kelurahan_cmb.DisplayMember = "NamaKelurahan";
                kelurahan_cmb.ValueMember = "IdKelurahan";
                kelurahan_cmb.SelectedIndex = -1;

                // Isi ComboBox NIK
                string query = "SELECT NIK FROM penduduk";
                MySqlCommand cmd = new MySqlCommand(query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                id_cmb.DataSource = dt;
                id_cmb.DisplayMember = "NIK";
                id_cmb.ValueMember = "NIK";
                id_cmb.SelectedIndex = -1;

                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal isi ComboBox: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NoKK_txt.Text) ||
                    string.IsNullOrWhiteSpace(Alamat_txt.Text) ||
                    kelurahan_cmb.SelectedValue == null ||
                    kecamatan_cmb.SelectedValue == null ||
                    kabupaten_cmb.SelectedValue == null ||
                    id_cmb.SelectedValue == null)
                {
                    MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                kartukeluarga.No_KK = NoKK_txt.Text;
                kartukeluarga.Alamat = Alamat_txt.Text;
                kartukeluarga.Id_Penduduk_Kepala = id_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kabupaten = kabupaten_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kelurahan = kelurahan_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kecamatan = kecamatan_cmb.SelectedValue.ToString();

                if (kartukeluarga.apakahAda(NoKK_txt.Text))
                {
                    MessageBox.Show("Nomor KK sudah ada di database!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                kartukeluarga.simpanKeluarga();
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihkan();
                tampilGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NoKK_txt.Text))
                {
                    MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kartukeluarga.No_KK = NoKK_txt.Text;
                    kartukeluarga.hapus();
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void NoKK_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
   
        }

        private void kartukeluarga_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.kartukeluarga_dgv.Rows[e.RowIndex];
                NoKK_txt.Text = baris.Cells[0].Value?.ToString() ?? "";
                Alamat_txt.Text = baris.Cells[1].Value?.ToString() ?? "";
                id_cmb.SelectedValue = baris.Cells[2].Value?.ToString() ?? "";
                kabupaten_cmb.SelectedValue = baris.Cells[3].Value?.ToString() ?? "";
                kecamatan_cmb.SelectedValue = baris.Cells[4].Value?.ToString() ?? "";
                kelurahan_cmb.SelectedValue = baris.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NoKK_txt.Text))
                {
                    MessageBox.Show("Nomor KK ga boleh kosong, bestie!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Alamat_txt.Text))
                {
                    MessageBox.Show("Alamat ga boleh kosong, yaa!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (id_cmb.SelectedIndex < 0)
                {
                    MessageBox.Show("Pilih NIK dulu!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (kelurahan_cmb.SelectedIndex < 0 || kecamatan_cmb.SelectedIndex < 0 || kabupaten_cmb.SelectedIndex < 0)
                {
                    MessageBox.Show("Pilih Kabupaten, Kecamatan, dan Kelurahan dulu, yaa!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!kartukeluarga.apakahAda(NoKK_txt.Text))
                {
                    MessageBox.Show("Data dengan NoKK ini ga ada, cek lagi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                kartukeluarga.No_KK = NoKK_txt.Text;
                kartukeluarga.Alamat = Alamat_txt.Text;
                kartukeluarga.Id_Penduduk_Kepala = id_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kabupaten = kabupaten_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kecamatan = kecamatan_cmb.SelectedValue.ToString();
                kartukeluarga.Id_Kelurahan = kelurahan_cmb.SelectedValue.ToString();

                kartukeluarga.ubahKK();
                MessageBox.Show("Data diubah, yeay! ");
                bersihkan();
                tampilGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah data: {ex.Message} ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void id_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opsional: Tambahkan logika jika diperlukan saat pilihan ComboBox berubah
        }


        private void id_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void kartukeluarga_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NoKK_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar?", "Konfirmasi",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pencarian_gbox_Enter(object sender, EventArgs e)
        {

        }

        private void kabupaten_lbl_Click(object sender, EventArgs e)
        {

        }

        private void kabupaten_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kelurahan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kecamatan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nik_lbl_Click(object sender, EventArgs e)
        {

        }

        private void f(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}