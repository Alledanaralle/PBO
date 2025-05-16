using KependudukanApp;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kependudukan
{
    class Login_cls
    {
        private Database db;

        public Login_cls()
        {
            db = new Database();
        }

        public bool CekLogin(string username, string password)
        {
            bool result = false;
            try
            {
                db.OpenConnection();
                string query = "SELECT id_user FROM user WHERE username = @user AND password = @pass";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    result = true;
                }
                reader.Close();
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, gagal login nih: {ex.Message} :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}