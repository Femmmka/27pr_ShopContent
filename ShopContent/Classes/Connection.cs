﻿using System.Data.SqlClient;

namespace ShopContent.Classes
{
    public class Connection
    {
        private static readonly string config = "server=127.0.0.1;" +
            "Trusted_Connection=No;" +
            "DataBase=ShopContent;" +
            "User=***;" +
            "PWD=***";

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(config);
            connection.Open();
            return connection;
        }
        public static SqlDataReader Query(string SQL, out SqlConnection connection)
        {
            connection = OpenConnection();
            return new SqlCommand(SQL, connection).ExecuteReader();
        }
        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
            SqlConnection.ClearPool(connection);
        }
    }
}
