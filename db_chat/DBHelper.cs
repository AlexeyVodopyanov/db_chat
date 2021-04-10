using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_chat
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;

        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "mysql60.hostland.ru";
                builder.UserID = "host1323541_itstep";
                builder.Password = "269f43dc";
                builder.Database = "host1323541_itstep21";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());

            }
            catch (Exception)
            {
            }
        }

        public static MySqlCommand RunQuery(string query, string username)
        {
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                connection.Close();
            }
            return cmd;
        }
    }
}
