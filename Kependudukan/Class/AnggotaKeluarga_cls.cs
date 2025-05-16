using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KependudukanApp;

namespace Kependudukan
{
    class AnggotaKeluarga_cls
    {
        private string _IdAnggota;
        private string _NoKK;
        private string _IdPenduduk;
        private string _StatusDalamKeluarga;

        private Database DBServer;
        private string Query;

        public AnggotaKeluarga_cls()
        {
            _IdAnggota = "";
            _NoKK = "";
            _IdPenduduk = "";
            _StatusDalamKeluarga = "";
            DBServer = new Database();
            Query = "";
        }

        public string IdAnggota
        {
            set { _IdAnggota = value; }
            get { return _IdAnggota; }
        }

        public string NoKK
        {
            set { _NoKK = value; }
            get { return _NoKK; }
        }

        public string IdPenduduk
        {
            set { _IdPenduduk = value; }
            get { return _IdPenduduk; }
        }

        public string StatusDalamKeluarga
        {
            set { _StatusDalamKeluarga = value; }
            get { return _StatusDalamKeluarga; }
        }

        public bool apakahAda(string IdAnggota)
        {
            bool cek = false;
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT * FROM anggotakeluarga WHERE IdAnggota = @IdAnggota";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdAnggota", IdAnggota);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    cek = true;
                }
                reader.Close();
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cek ID anggota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cek;
        }

        public void simpan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "INSERT INTO anggotakeluarga (IdAnggota, NoKK, IdPenduduk, StatusDalamKeluarga) " +
                        "VALUES (@IdAnggota, @NoKK, @IdPenduduk, @StatusDalamKeluarga)";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdAnggota", _IdAnggota);
                cmd.Parameters.AddWithValue("@NoKK", _NoKK);
                cmd.Parameters.AddWithValue("@IdPenduduk", _IdPenduduk);
                cmd.Parameters.AddWithValue("@StatusDalamKeluarga", _StatusDalamKeluarga);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal simpan data!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void update(string IdAnggota, string NoKK, string IdPenduduk, string StatusDalamKeluarga)
        {
            try
            {
                DBServer.OpenConnection();
                Query = "UPDATE anggotakeluarga SET NoKK = @NoKK, IdPenduduk = @IdPenduduk, " +
                        "StatusDalamKeluarga = @StatusDalamKeluarga WHERE IdAnggota = @IdAnggota";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdAnggota", IdAnggota);
                cmd.Parameters.AddWithValue("@NoKK", NoKK);
                cmd.Parameters.AddWithValue("@IdPenduduk", IdPenduduk);
                cmd.Parameters.AddWithValue("@StatusDalamKeluarga", StatusDalamKeluarga);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal ubah data!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void delete(string IdAnggota)
        {
            try
            {
                DBServer.OpenConnection();
                Query = "DELETE FROM anggotakeluarga WHERE IdAnggota = @IdAnggota";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdAnggota", IdAnggota);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal hapus data, yaa!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DataTable tampilSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT ak.IdAnggota, ak.NoKK, ak.IdPenduduk, ak.StatusDalamKeluarga " +
                        "FROM anggotakeluarga ak " +
                        "JOIN penduduk p ON ak.IdPenduduk = p.NIK " +
                        "ORDER BY ak.IdAnggota";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data anggota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable tampilDgStatus(string StatusDalamKeluarga)
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT * FROM anggotakeluarga WHERE StatusDalamKeluarga LIKE @StatusDalamKeluarga";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@StatusDalamKeluarga", $"{StatusDalamKeluarga}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cari data anggota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string buatKode()
        {
            string kode = "";
            int data = 0;
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT IFNULL(MAX(IdAnggota), 0)+1 AS kode FROM anggotakeluarga";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                object result = cmd.ExecuteScalar();
                DBServer.CloseConnection();

                if (result != null)
                {
                    data = Convert.ToInt32(result);
                }

                if (data >= 1 && data < 10)
                {
                    kode = "0" + data.ToString();
                }
                else if (data >= 10 && data < 100)
                {
                    kode = data.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal generate kode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kode;
        }
    }
}