using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KependudukanApp;

namespace Kependudukan
{
    class KartuKeluarga_cls
    {
        private string _NoKK;
        private string _Alamat;
        private string _IdKelurahan;
        private string _IdKecamatan;
        private string _IdKabupaten;
        private string _IdPendudukKepala;

        private Database DBServer;
        private string Query;

        public KartuKeluarga_cls()
        {
            _NoKK = "";
            _Alamat = "";
            _IdKelurahan = "";
            _IdKecamatan = "";
            _IdKabupaten = "";
            _IdPendudukKepala = "";
            DBServer = new Database();
            Query = "";
        }

        public string No_KK
        {
            get { return _NoKK; }
            set { _NoKK = value; }
        }

        public string Alamat
        {
            get { return _Alamat; }
            set { _Alamat = value; }
        }

        public string Id_Kelurahan
        {
            get { return _IdKelurahan; }
            set { _IdKelurahan = value; }
        }

        public string Id_Kecamatan
        {
            get { return _IdKecamatan; }
            set { _IdKecamatan = value; }
        }

        public string Id_Kabupaten
        {
            get { return _IdKabupaten; }
            set { _IdKabupaten = value; }
        }

        public string Id_Penduduk_Kepala
        {
            get { return _IdPendudukKepala; }
            set { _IdPendudukKepala = value; }
        }

        public DataTable tampilSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT NoKK, Alamat, IdPendudukKepala, IdKabupaten, IdKecamatan, IdKelurahan FROM kartukeluarga";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data KK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public void simpanKeluarga()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "INSERT INTO kartukeluarga (NoKK, Alamat, IdPendudukKepala, IdKabupaten, IdKecamatan, IdKelurahan) " +
                        "VALUES (@NoKK, @Alamat, @IdPendudukKepala, @IdKabupaten, @IdKecamatan, @IdKelurahan)";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@NoKK", _NoKK);
                cmd.Parameters.AddWithValue("@Alamat", _Alamat);
                cmd.Parameters.AddWithValue("@IdPendudukKepala", _IdPendudukKepala);
                cmd.Parameters.AddWithValue("@IdKabupaten", _IdKabupaten);
                cmd.Parameters.AddWithValue("@IdKecamatan", _IdKecamatan);
                cmd.Parameters.AddWithValue("@IdKelurahan", _IdKelurahan);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal simpan data, say!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan KK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void ubahKK()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "UPDATE kartukeluarga SET Alamat = @Alamat, IdKelurahan = @IdKelurahan, " +
                        "IdKecamatan = @IdKecamatan, IdKabupaten = @IdKabupaten, " +
                        "IdPendudukKepala = @IdPendudukKepala WHERE NoKK = @NoKK";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@NoKK", _NoKK);
                cmd.Parameters.AddWithValue("@Alamat", _Alamat);
                cmd.Parameters.AddWithValue("@IdKelurahan", _IdKelurahan);
                cmd.Parameters.AddWithValue("@IdKecamatan", _IdKecamatan);
                cmd.Parameters.AddWithValue("@IdKabupaten", _IdKabupaten);
                cmd.Parameters.AddWithValue("@IdPendudukKepala", _IdPendudukKepala);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal ubah data, bestie!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah KK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void hapus()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "DELETE FROM kartukeluarga WHERE NoKK = @NoKK";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@NoKK", _NoKK);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal hapus data, yaa!");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus KK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool apakahAda(string noKK)
        {
            bool cek = false;
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT COUNT(*) FROM kartukeluarga WHERE NoKK = @NoKK";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@NoKK", noKK);
                object result = cmd.ExecuteScalar();
                cek = result != null && Convert.ToInt32(result) > 0;
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cek NoKK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cek;
        }

        public DataTable tampilDgNo(string NoKK)
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT NoKK, Alamat, IdPendudukKepala FROM kartukeluarga WHERE NoKK LIKE @NoKK";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@NoKK", $"%{NoKK}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cari KK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string generateAutoNoKK()
        {
            string lastNoKK = "";
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT NoKK FROM kartukeluarga ORDER BY NoKK DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastNoKK = reader["NoKK"].ToString();
                }
                reader.Close();
                DBServer.CloseConnection();

                if (!string.IsNullOrEmpty(lastNoKK))
                {
                    int angka = int.Parse(lastNoKK.Substring(2)) + 1;
                    return "KK" + angka.ToString("D3");
                }
                return "KK001";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal generate NoKK: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "KK001";
            }
        }
    }
}