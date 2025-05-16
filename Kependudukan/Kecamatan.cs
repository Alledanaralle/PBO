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
   
    public partial class Kecamatan: Form
    {
        private Database db;
        Kecamatan_cls kecamatan = new Kecamatan_cls();
        public Kecamatan()
        {
            InitializeComponent();
        }

        private void Kecamatan_Load(object sender, EventArgs e)
        {
            Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
            int autoId = kecamatan.generateAuto(); // kalau generateAuto() return int
            IdKecamatan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKecamatan_tb.Clear();
            pencarian_tb.Clear();
            NamaKecamatan_tb.Focus();
            tampilGrid();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(IdKecamatan_tb.Text) ||
                    string.IsNullOrWhiteSpace(NamaKecamatan_tb.Text))
                {
                    MessageBox.Show("Silakan lengkapi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IdKecamatan_tb.Focus();
                    return;
                }

                kecamatan.IdKecamatan = IdKecamatan_tb.Text;
                kecamatan.NamaKecamatan = NamaKecamatan_tb.Text;

                kecamatan.simpanKecamatan();
                MessageBox.Show("Data berhasil disimpan!");
                Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }

            int autoId = kecamatan.generateAuto(); // kalau generateAuto() return int
            IdKecamatan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NamaKecamatan_tb.Text))
                {
                    MessageBox.Show("Silakan pilih data yang ingin diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IdKecamatan_tb.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin mengubah data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    kecamatan.IdKecamatan = IdKecamatan_tb.Text;
                    kecamatan.NamaKecamatan = NamaKecamatan_tb.Text;

                    kecamatan.ubahKecamatan();
                    MessageBox.Show("Data berhasil diubah.");
                    Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
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

            int autoId = kecamatan.generateAuto(); // kalau generateAuto() return int
            IdKecamatan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(IdKecamatan_tb.Text))
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
                    kecamatan.IdKecamatan = IdKecamatan_tb.Text;

                    kecamatan.hapusKecamatan();
                    MessageBox.Show("Data berhasil dihapus!");
                    Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
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


            NamaKecamatan_tb.Clear();

        }

        private void bersihkan_btn_Click(object sender, EventArgs e)
        {
            Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
            int autoId = kecamatan.generateAuto(); // kalau generateAuto() return int
            IdKecamatan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKecamatan_tb.Clear();
            pencarian_tb.Clear();
            IdKecamatan_tb.Focus();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Kecamatan_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Kecamatan_DGV.Rows[e.RowIndex];
                IdKecamatan_tb.Text = row.Cells["IdKecamatan"].Value.ToString();
                NamaKecamatan_tb.Text = row.Cells["NamaKecamatan"].Value.ToString();
            }

        }

        void tampilGrid()
        {
            if (pencarian_tb.Text.Length == 0)
            {
                Kecamatan_DGV.DataSource = kecamatan.tampilSemuaKecamatan();
            }
            else
            {
                Kecamatan_DGV.DataSource = kecamatan.tampilDgNo(pencarian_tb.Text);
            }

        }
        void bersihkan()
        {
            int autoId = kecamatan.generateAuto(); // kalau generateAuto() return int
            IdKecamatan_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKecamatan_tb.Clear();
            NamaKecamatan_tb.Focus();

        }

        private void pencarian_tb_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }
    }
}
