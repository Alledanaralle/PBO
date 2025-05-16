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
    public partial class Kabupaten: Form
    {
        private Database db;
        Kabupaten_cls kabupaten = new Kabupaten_cls();

        public Kabupaten()
        {
            InitializeComponent();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(IdKabupaten_tb.Text) ||
                    string.IsNullOrWhiteSpace(NamaKabupaten_tb.Text))
                {
                    MessageBox.Show("Silakan lengkapi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IdKabupaten_tb.Focus();
                    return;
                }

                kabupaten.IdKabupaten = IdKabupaten_tb.Text;
                kabupaten.NamaKabupaten = NamaKabupaten_tb.Text;

                kabupaten.simpanKabupaten();
                MessageBox.Show("Data berhasil disimpan!");
                Kabupaten_DGV.DataSource = kabupaten.tampilSemuaKabupaten();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }

            int autoId = kabupaten.generateAuto(); // asumsikan generateAuto() return int
            IdKabupaten_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NamaKabupaten_tb.Text))
                {
                    MessageBox.Show("Silakan pilih data yang ingin diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IdKabupaten_tb.Focus();
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
                    kabupaten.IdKabupaten = IdKabupaten_tb.Text;
                    kabupaten.NamaKabupaten = NamaKabupaten_tb.Text;

                    kabupaten.ubahKabupaten();
                    MessageBox.Show("Data berhasil diubah.");
                    Kabupaten_DGV.DataSource = kabupaten.tampilSemuaKabupaten();
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

            int autoId = kabupaten.generateAuto(); // asumsikan generateAuto() return int
            IdKabupaten_tb.Text = autoId.ToString(); // tampilkan ke textbox
            bersihkan();

        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(IdKabupaten_tb.Text))
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
                    kabupaten.IdKabupaten = IdKabupaten_tb.Text;

                    kabupaten.hapusKabupaten();
                    MessageBox.Show("Data berhasil dihapus!");
                    Kabupaten_DGV.DataSource = kabupaten.tampilSemuaKabupaten();
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

            NamaKabupaten_tb.Clear();
        }

        private void bersihkan_btn_Click(object sender, EventArgs e)
        {
            int autoId = kabupaten.generateAuto(); // kalau generateAuto() return int
            IdKabupaten_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKabupaten_tb.Clear();
            pencarian_tb.Clear();
            NamaKabupaten_tb.Focus();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void IdKabupaten_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NamaKabupaten_tb_TextChanged(object sender, EventArgs e)
        {

        }
        void bersihkan()
        {
            int autoId = kabupaten.generateAuto(); // kalau generateAuto() return int
            IdKabupaten_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKabupaten_tb.Clear();
            NamaKabupaten_tb.Focus();
        }

        private void Kabupaten_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Kabupaten_DGV.Rows[e.RowIndex];
                IdKabupaten_tb.Text = row.Cells["IdKabupaten"].Value.ToString();
                NamaKabupaten_tb.Text = row.Cells["NamaKabupaten"].Value.ToString();
            }

        }

        private void pencarian_tb_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        void tampilGrid()
        {
            if (pencarian_tb.Text.Length == 0)
            {
                Kabupaten_DGV.DataSource = kabupaten.tampilSemuaKabupaten();
            }
            else
            {
                Kabupaten_DGV.DataSource = kabupaten.tampilDgNo(pencarian_tb.Text);
            }

        }

        private void Kabupaten_Load(object sender, EventArgs e)
        {
            Kabupaten_DGV.DataSource = kabupaten.tampilSemuaKabupaten();
            int autoId = kabupaten.generateAuto(); // kalau generateAuto() return int
            IdKabupaten_tb.Text = autoId.ToString(); // tampilkan ke textbox
            NamaKabupaten_tb.Focus();
        }
    }
}
