using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using KependudukanApp;

namespace Kependudukan
{
    public partial class DataPenduduk : Form
    {
        private Database db;

        public DataPenduduk()
        {
            InitializeComponent();
            db = new Database(); // Inisialisasi koneksi
            // Set default pesan kalo DataGridView kosong
            dataGridViewPenduduk.Rows.Clear();
            dataGridViewPenduduk.ColumnCount = 0;
            //dataGridViewPenduduk.Columns[0].Name = "Info";
            //dataGridViewPenduduk.Rows.Add("Tidak ada data");
        }


        public void LoadDataPenduduk()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT NIK, Nama, TanggalLahir, JenisKelamin, IdKelurahan, pekerjaan, status, agama FROM Penduduk";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                // Cek apakah data kosong
                if (dt.Rows.Count == 0)
                {
                    dataGridViewPenduduk.DataSource = null; // Reset grid
                    dataGridViewPenduduk.Rows.Clear();
                    dataGridViewPenduduk.ColumnCount = 0;
                    dataGridViewPenduduk.Columns[0].Name = "Info";
                    //dataGridViewPenduduk.Columns[0].Width = dataGridViewPenduduk.Width - 20; // Sesuain lebar
                    dataGridViewPenduduk.Rows.Add("Yah, data penduduk kosong nih! :(");
                    //MessageBox.Show("Yah, data penduduk kosong nih! :(", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewPenduduk.DataSource = dt; // Bind data ke grid
                    //MessageBox.Show($"Data penduduk loaded, yay! >_< Jumlah: {dt.Rows.Count} baris", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTambahData_Click(object sender, EventArgs e)
        {
            FormTambahPenduduk formTambah = new FormTambahPenduduk();
            formTambah.FormClosed += (s, args) => LoadDataPenduduk(); // Refresh data setelah form ditutup
            formTambah.ShowDialog(); // Buka form sebagai dialog
        }
        public void DataPenduduk_Load(object sender, EventArgs e)
        {
            LoadDataPenduduk(); // Panggil fungsi load data
        }

        private void buttonHapusData_Click(object sender, EventArgs e)
        {
            FormHapusPenduduk formHapus = new FormHapusPenduduk(this); // Pass this ke form hapus
            formHapus.ShowDialog();
        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            FormEditPenduduk formEdit = new FormEditPenduduk(this); // Pass this ke form edit
            formEdit.ShowDialog();
        }
    }
}