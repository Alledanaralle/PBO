using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KependudukanApp;

namespace Kependudukan
{
    using System.Collections;
    using System.Data;
    using System.Data.SqlTypes;
    using System.Drawing;
    using System.Runtime.ConstrainedExecution;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    
    class Kelurahan_class
    {
        private string _IdKelurahan;
        private string _NamaKelurahan;
        private string _KodePos;

        private Database DBServer;
        private string Query;

        public Kelurahan_class()
        {
            _IdKelurahan = "";
            _NamaKelurahan = "";
            _KodePos = "";
            DBServer = new Database();
            Query = "";
        }

        //Id
        public string IdKelurahan
        {
            get { return _IdKelurahan; }
            set { _IdKelurahan = value; }
        }

        //Nama
        public string NamaKelurahan
        {
            get { return _NamaKelurahan; }
            set { _NamaKelurahan = value; }
        }

        //Kode Pos
        public string KodePos
        {
            get { return _KodePos; }
            set { _KodePos= value; }
        }

        //TAMPIL
        public DataTable tampilSemuaKelurahan()
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT IdKelurahan, NamaKelurahan, KodePos FROM kelurahan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal load data kelurahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //SIMPAN
        public void simpanKelurahan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "INSERT INTO kelurahan (IdKelurahan, NamaKelurahan, KodePos) VALUES (@IdKelurahan, @NamaKelurahan, @KodePos)";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKelurahan", _IdKelurahan);
                cmd.Parameters.AddWithValue("@NamaKelurahan", _NamaKelurahan);
                cmd.Parameters.AddWithValue("@KodePos", _KodePos);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal simpan data, say! 😿");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal simpan kelurahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UBAH
        public void ubahKelurahan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "UPDATE kelurahan SET NamaKelurahan = @NamaKelurahan, KodePos = @KodePos WHERE IdKelurahan = @IdKelurahan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKelurahan", _IdKelurahan);
                cmd.Parameters.AddWithValue("@NamaKelurahan", _NamaKelurahan);
                cmd.Parameters.AddWithValue("@KodePos", _KodePos);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal ubah data, bestie! 😿");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal ubah kelurahan: {ex.Message} 😿", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //HAPUS
        public void hapusKelurahan()
        {
            try
            {
                DBServer.OpenConnection();
                Query = "DELETE FROM kelurahan WHERE IdKelurahan = @IdKelurahan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKelurahan", _IdKelurahan);
                int hasil = cmd.ExecuteNonQuery();

                if (hasil <= 0)
                {
                    throw new Exception("Gagal hapus data, yaa! 😿");
                }
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal hapus kelurahan: {ex.Message} 😿", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable tampilDgNo(string IdKelurahan)
        {
            DataTable dt = new DataTable();
            try
            {
                DBServer.OpenConnection();
                Query = "SELECT * FROM kelurahan WHERE IdKelurahan LIKE @IdKelurahan";
                MySqlCommand cmd = new MySqlCommand(Query, DBServer.GetConnection());
                cmd.Parameters.AddWithValue("@IdKelurahan", $"%{IdKelurahan}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBServer.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal cari kelurahan: {ex.Message} 😿", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int generateAuto()
        {
            int nextId = 1;
            try
            {
                DBServer.OpenConnection();
                string query = "SELECT MAX(IdKelurahan) AS MaxId FROM kelurahan";
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
                MessageBox.Show($"Oops, gagal generate ID: {ex.Message} 😿", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nextId;
        }

    }
}