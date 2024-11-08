using System;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Models;
using UTS_PBO.App.Core;
using NpgsqlTypes;

namespace UTS_PBO.App.Context
{
    internal class AdminContext : DataWrapper
    {
        private static string table = "admin";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataAdmin = queryExecutor(query);
            return dataAdmin;
        }

        // get by id
        public static M_Admin GetById(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            DataTable dataAdmin = queryExecutor(query, parameters);
            DataRow adminRow = dataAdmin.Rows[0];
            M_Admin admin = new M_Admin()
            {
                id = Convert.ToInt32(adminRow["id"]),
                username = adminRow["username"].ToString(),
                password = adminRow["password"].ToString(),
            };
            return admin;
        }
        public static void AddAdmin(M_Admin adminbaru)
        {
            string query = $"INSERT INTO {table} (username,password) values (@username,@password)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = adminbaru.username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = adminbaru.password},
            };
            commandExecutor(query, parameters);
        }
       
        public static void UpdateAdmin(M_Admin adminbaru)
        {
            string query = $"UPDATE {table} SET username = @username, password = @password WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = adminbaru.username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = adminbaru.password},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = adminbaru.id},
            };
            commandExecutor(query, parameters);
        }
       
        public static void DeleteAdmin(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }
    }
}