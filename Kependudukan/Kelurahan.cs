using KependudukanApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kependudukan
{
    public partial class Kelurahan: Form
    {
        private Database db;
        Kelurahan_class kelurahan = new Kelurahan_class();
        public Kelurahan()
        {
            InitializeComponent();
        }

        //Tombol Exit
        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void Kelurahan_Load(object sender, EventArgs e)
        {
            kelurahan_DGV.DataSource = kelurahan.tampilSemuaKelurahan();
            int autoId = kelurahan.generateAuto(); // kalau generateAuto() return int
            idKelurahan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            namaKelurahan_tb.Focus();
        }

        private void bersihkan_btn_Click(object sender, EventArgs e)
        {
            int autoId = kelurahan.generateAuto(); // kalau generateAuto() return int
            idKelurahan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            namaKelurahan_tb.Focus();
            namaKelurahan_tb.Clear();
            kodePos_tb.Clear();
            pencarian_tb.Clear();
            

        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idKelurahan_tb.Text))
                {
                    MessageBox.Show("Silakan pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    kelurahan.IdKelurahan = idKelurahan_tb.Text;

                    kelurahan.hapusKelurahan();
                    MessageBox.Show("Data berhasil dihapus!");
                    kelurahan_DGV.DataSource = kelurahan.tampilSemuaKelurahan();
                }
                else
                {
                    MessageBox.Show("Penghapusan dibatalkan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }

            int autoId = kelurahan.generateAuto(); // kalau generateAuto() return int
            idKelurahan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(namaKelurahan_tb.Text))
                {
                    MessageBox.Show("Silakan pilih data yang ingin diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idKelurahan_tb.Focus();
                    return;
                }
                

                // Validasi konfirmasi dari user
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin mengubah data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Ambil data dari input
                    kelurahan.IdKelurahan = idKelurahan_tb.Text;
                    kelurahan.NamaKelurahan = namaKelurahan_tb.Text;
                    kelurahan.KodePos = kodePos_tb.Text;

                    // Update data
                    kelurahan.ubahKelurahan();

                    // Tampilkan pesan & refresh tabel
                    MessageBox.Show("Data berhasil diubah.");
                    kelurahan_DGV.DataSource = kelurahan.tampilSemuaKelurahan();
                }
                else
                {
                    MessageBox.Show("Perubahan dibatalkan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengubah data: " + ex.Message);
            }

            int autoId = kelurahan.generateAuto(); // kalau generateAuto() return int
            idKelurahan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idKelurahan_tb.Text) ||
                    string.IsNullOrWhiteSpace(namaKelurahan_tb.Text) ||
                    string.IsNullOrWhiteSpace(kodePos_tb.Text))
                {
                    MessageBox.Show("Silakan lengkapi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idKelurahan_tb.Focus();
                    return;
                }


                kelurahan.IdKelurahan = idKelurahan_tb.Text;
                kelurahan.NamaKelurahan = namaKelurahan_tb.Text;
                kelurahan.KodePos = kodePos_tb.Text;

                kelurahan.simpanKelurahan();
                MessageBox.Show("Data berhasil disimpan!");
                kelurahan_DGV.DataSource = kelurahan.tampilSemuaKelurahan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
            int autoId = kelurahan.generateAuto(); // kalau generateAuto() return int
            idKelurahan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();
        }

        private void pencarian_tb_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

      

        private void kelurahan_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kelurahan_DGV.Rows[e.RowIndex];
                idKelurahan_tb.Text = row.Cells["IdKelurahan"].Value.ToString();
                namaKelurahan_tb.Text = row.Cells["NamaKelurahan"].Value.ToString();
                kodePos_tb.Text = row.Cells["KodePos"].Value.ToString();
            }

        }

        private void idKelurahan_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void namaKelurahan_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                kodePos_tb.Focus();
                e.Handled = true; // Cegah suara "ding"
            }
        }

        private void kodePos_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Cek: hanya boleh angka
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // tolak input selain angka
                return;
            }

            // Cek: panjang maksimum 5 digit
            if (kodePos_tb.Text.Length >= 5)
            {
                e.Handled = true; // tolak input jika sudah 5 digit
            }
        }

        void bersihkan()
        {
            
            namaKelurahan_tb.Clear();
            kodePos_tb.Clear();

            namaKelurahan_tb.Focus();
        }

        void tampilGrid()
        {
            if (pencarian_tb.Text.Length == 0)
            {
                kelurahan_DGV.DataSource = kelurahan.tampilSemuaKelurahan();
            }
            else
            {
                kelurahan_DGV.DataSource = kelurahan.tampilDgNo(pencarian_tb.Text);
            }

        }

    }

}

