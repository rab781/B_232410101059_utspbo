using System;
using Npgsql;
using System.Data;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Core
{
    internal class DataWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "UTS PBO";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "raffli81";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        public static void openConnection()
        {
            string connectionString = $"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }


        public static void CloseConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                CloseConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }

}
