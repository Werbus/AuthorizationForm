using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace WF_project
{
    class MyDataBase
    {
        private static DataTable table;
        private static MySqlCommand command;
        private static MySqlDataAdapter adapter = new MySqlDataAdapter();
        private static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=mydb");
        public static void Connect()
        {
            if (connection.State == ConnectionState.Closed)
            connection.Open();
        }
        public static void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static void regUser(string login, string password)
        {
            command = new MySqlCommand("INSERT INTO users (Username, Password) VALUES (@uL, @uP)", connection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
        }
        public static void logUser(string login, string password)
        {
            table = new DataTable();
            command = new MySqlCommand("SELECT * FROM users WHERE Username = @uL AND Password = @uP", connection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                DataControl.Check = true;
            else
                DataControl.Check = false;
        }
        public static void TakeData()
        {
            table = new DataTable();
            command = new MySqlCommand("SELECT * FROM users", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataControl.data = table;
        }
        public static void deleteData(int id, string username, string password)
        {
            command = new MySqlCommand("DELETE FROM users WHERE ID = @id AND Username = @uL AND Password = @uP", connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
            TakeData();
        }
    }
}
