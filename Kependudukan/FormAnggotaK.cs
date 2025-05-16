using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KependudukanApp;
using MySql.Data.MySqlClient;

namespace Kependudukan
{
    public partial class FormAnggotaK: Form
    {
        //deklarasi objek dan koneksi database
        AnggotaKeluarga_cls anggotakeluarga = new AnggotaKeluarga_cls();
        Database DBServer; //tambahkan instance untuk koneksi db
        public FormAnggotaK()
        {
            InitializeComponent(); //inisialisasi komponen UI form
            DBServer = new Database(); //inisialisasi dbserver
            this.Shown += new EventHandler(FormAnggotaK_Shown); //saat form pertama kali ditampilkan
        }

        private void id_prodi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //Event saat form ditampilkan, mengarahkan fokus ke input ID anggota
        private void FormAnggotaK_Shown(object sender, EventArgs e)
        {
            id_anggota_txt.Focus(); // Fokus tetap ke textbox id anggota
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            
        }



        private void batal_btn_Click(object sender, EventArgs e)
        {

        }

        private void no_kk_lbl_Click(object sender, EventArgs e)
        {

        }

        private void no_kk_lbl_Click_1(object sender, EventArgs e)
        {

        }

        private void id_penduduk_lbl_Click(object sender, EventArgs e)
        {

        }

        private void FormAnggotaK_Load(object sender, EventArgs e)
        {
            tampilGrid();
            isiNoKK(); //panggil method utk mengisi combobox
            isiIdPenduduk(); //panggil method utk mengisi combobox
            bersihkan();
        }

        private void id_anggota_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        // Event handler untuk tombol simpan data anggota
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //validasi input utk memastikan semua field diisi
                if (string.IsNullOrEmpty(id_anggota_txt.Text) ||
                no_kk_cmb.SelectedIndex < 0 ||
                id_penduduk_cmb.SelectedIndex < 0 ||
                string.IsNullOrEmpty(status_txt.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //set data anggota dari input pengguna
                anggotakeluarga.IdAnggota = id_anggota_txt.Text;
                anggotakeluarga.NoKK = no_kk_cmb.SelectedValue.ToString();
                anggotakeluarga.IdPenduduk = id_penduduk_cmb.SelectedValue.ToString();
                anggotakeluarga.StatusDalamKeluarga = status_txt.Text;

                // Mengecek apakah data sudah ada berdasarkan ID Anggota
                if (anggotakeluarga.apakahAda(id_anggota_txt.Text))
                {
                    MessageBox.Show("ID sudah ada di database!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //simpan data ke database
                anggotakeluarga.simpan();
                MessageBox.Show("Data berhasil disimpan!");
                tampilGrid();//refresh data grid
                bersihkan();//kosongkan form input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method untuk membersihkan form setelah operasi
        void bersihkan()
        {
            id_anggota_txt.Text = anggotakeluarga.buatKode(); // hanya ID anggota yang digenerate otomatis
            no_kk_cmb.SelectedIndex = -1;//reset combobox
            id_penduduk_cmb.SelectedIndex = -1;//reset combobox id penduduk
            status_txt.Clear();//hapus teks status
            id_anggota_txt.Focus();//set fokus ke input id anggota
        }

        //Menampilkan data anggota ke DataGridView
        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                anggota_dgv.DataSource = anggotakeluarga.tampilSemua();
            }
            else
            {
                anggota_dgv.DataSource = anggotakeluarga.tampilDgStatus(cari_txt.Text);
            }
        }

        //mengisi data combobox nokk
        void isiNoKK()
        {
            try
            {
                Database db = new Database();
                db.OpenConnection();
                string query = "SELECT NoKK FROM kartukeluarga";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                db.CloseConnection();

                no_kk_cmb.DataSource = dt;
                no_kk_cmb.DisplayMember = "NoKK";
                no_kk_cmb.ValueMember = "NoKK";
                no_kk_cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal isi NoKK: {ex.Message} 😿", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //mengisi data combobox idpenduduk
        void isiIdPenduduk()
        {
            try
            {
                Database db = new Database();
                db.OpenConnection();
                string query = "SELECT NIK FROM penduduk";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                db.CloseConnection();

                id_penduduk_cmb.DataSource = dt;
                id_penduduk_cmb.DisplayMember = "NIK";
                id_penduduk_cmb.ValueMember = "NIK";
                id_penduduk_cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal isi IdPenduduk: {ex.Message} 😿", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar dari aplikasi", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void batal_btn_Click_1(object sender, EventArgs e)
        {
            bersihkan();
            id_anggota_txt.Focus();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void anggota_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.anggota_dgv.Rows[e.RowIndex];

                id_anggota_txt.Text = row.Cells[0].Value?.ToString() ??"";
                no_kk_cmb.Text = row.Cells[1].Value?.ToString() ??"";
                id_penduduk_cmb.Text = row.Cells[2].Value?.ToString()??"";
                status_txt.Text = row.Cells[3].Value?.ToString()??"";
            }

        }

        private void nik_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validasi agar semua input wajib diisi
                if (string.IsNullOrWhiteSpace(id_anggota_txt.Text) ||
                    no_kk_cmb.SelectedIndex < 0 ||
                    id_penduduk_cmb.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(status_txt.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Set data ke objek anggota keluarga
                anggotakeluarga.IdAnggota = id_anggota_txt.Text;
                anggotakeluarga.NoKK = no_kk_cmb.SelectedValue.ToString();
                anggotakeluarga.IdPenduduk = id_penduduk_cmb.SelectedValue.ToString();
                anggotakeluarga.StatusDalamKeluarga = status_txt.Text;

                // Update data anggota keluarga
                anggotakeluarga.update(id_anggota_txt.Text, no_kk_cmb.SelectedValue.ToString(), id_penduduk_cmb.SelectedValue.ToString(), status_txt.Text);
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihkan();
                tampilGrid();
                no_kk_cmb.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void status_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_anggota_txt.Text))
                {
                    MessageBox.Show("Pilih data yang mau dihapus dulu, yaa!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!anggotakeluarga.apakahAda(id_anggota_txt.Text))
                {
                    MessageBox.Show("Data dengan ID ini ga ada, cek lagi", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Yakin hapus data ini?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    anggotakeluarga.delete(id_anggota_txt.Text);
                    MessageBox.Show("Data terhapus, yay! >_<");
                    bersihkan();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Hapus dibatalkan, tenang aja! 😽");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus data: {ex.Message} 😿", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anggota_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
