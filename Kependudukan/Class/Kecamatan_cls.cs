using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KependudukanApp;

namespace Kependudukan
{
    class Kecamatan_cls
    {
        private string _IdKecamatan;
        private string _NamaKecamatan;

        private Database DBServer;
        private string Query;

        public Kecamatan_cls()
        {
            _IdKecamatan = "";
            _NamaKecamatan = "";
            DBServer = new Database();
            Query = "";
        }

        // Id
        public string IdKecamatan
        {
            get { return _IdKecamatan; }
            set { _IdKecamatan = value; }
        }

        // Nama
        public string NamaKecamatan
        {
            get { return _NamaKecamatan; }
            set { _NamaKecamatan = value; }
        }

        // TAMPIL
        public DataTable tampilSemuaKecamatan()
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT IdKecamatan, NamaKecamatan FROM kecamatan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data kecamatan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // SIMPAN
        public void simpanKecamatan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "INSERT INTO kecamatan (IdKecamatan, NamaKecamatan) VALUES (@IdKecamatan, @NamaKecamatan)";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKecamatan", _IdKecamatan);
                cmd.Parameters.AddWithValue("@NamaKecamatan", _NamaKecamatan);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal simpan data! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan kecamatan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UBAH
        public void ubahKecamatan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "UPDATE kecamatan SET NamaKecamatan = @NamaKecamatan WHERE IdKecamatan = @IdKecamatan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKecamatan", _IdKecamatan);
                cmd.Parameters.AddWithValue("@NamaKecamatan", _NamaKecamatan);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal ubah data! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah kecamatan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HAPUS
        public void hapusKecamatan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "DELETE FROM kecamatan WHERE IdKecamatan = @IdKecamatan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKecamatan", _IdKecamatan);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal hapus data, yaa! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus kecamatan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable tampilDgNo(string IdKecamatan)
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT * FROM kecamatan WHERE IdKecamatan LIKE @IdKecamatan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKecamatan", $"%{IdKecamatan}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cari kecamatan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int generateAuto()
        {
            int nextId = 1;
            try
            {
                DBServer.OpenConnection();
                string query = "SELECT MAX(IdKecamatan) AS MaxId FROM kecamatan";
                MySqlCommand cmd = new MySqlCommand(query, DBServer.GetConnection());
                object result = cmd.ExecuteScalar();
                DBServer.CloseConnection();

                if (result != null && result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal generate ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nextId;
        }
    }
}