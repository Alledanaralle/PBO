using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KependudukanApp;

namespace Kependudukan
{
    class Kabupaten_cls
    {
        private string _IdKabupaten;
        private string _NamaKabupaten;

        private Database DBServer;
        private string Query;

        public Kabupaten_cls()
        {
            _IdKabupaten = "";
            _NamaKabupaten = "";
            DBServer = new Database();
            Query = "";
        }

        // Id
        public string IdKabupaten
        {
            get { return _IdKabupaten; }
            set { _IdKabupaten = value; }
        }

        // Nama
        public string NamaKabupaten
        {
            get { return _NamaKabupaten; }
            set { _NamaKabupaten = value; }
        }

        // TAMPIL
        public DataTable tampilSemuaKabupaten()
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT IdKabupaten, NamaKabupaten FROM kabupaten";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data kabupaten: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // SIMPAN
        public void simpanKabupaten()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "INSERT INTO kabupaten (IdKabupaten, NamaKabupaten) VALUES (@IdKabupaten, @NamaKabupaten)";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKabupaten", _IdKabupaten);
                cmd.Parameters.AddWithValue("@NamaKabupaten", _NamaKabupaten);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal simpan data! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan kabupaten: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UBAH
        public void ubahKabupaten()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "UPDATE kabupaten SET NamaKabupaten = @NamaKabupaten WHERE IdKabupaten = @IdKabupaten";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKabupaten", _IdKabupaten);
                cmd.Parameters.AddWithValue("@NamaKabupaten", _NamaKabupaten);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal ubah data! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah kabupaten: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HAPUS
        public void hapusKabupaten()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "DELETE FROM kabupaten WHERE IdKabupaten = @IdKabupaten";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKabupaten", _IdKabupaten);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal hapus data! :(");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus kabupaten: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable tampilDgNo(string IdKabupaten)
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT * FROM kabupaten WHERE IdKabupaten LIKE @IdKabupaten";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKabupaten", $"%{IdKabupaten}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cari kabupaten: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int generateAuto()
        {
            int nextId = 1;
            try
            {
                DBServer.OpenConnection();
                string query = "SELECT MAX(IdKabupaten) AS MaxId FROM kabupaten";
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