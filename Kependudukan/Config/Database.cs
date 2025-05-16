using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KependudukanApp
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=penduduk;Uid=root;Pwd=;";

        public Database()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Buka koneksi
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    //MessageBox.Show("Koneksi ke database sukses, yay! >_<", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal konek ke database: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tutup koneksi
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ehh, gagal nutup koneksi: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Getter buat koneksi
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}