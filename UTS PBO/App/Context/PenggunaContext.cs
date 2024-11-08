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
    internal class PenggunaContext : DataWrapper
    {
        private static string table = "pengguna";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPengguna = queryExecutor(query);
            return dataPengguna;
        }

        public static M_Pengguna GetById(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            DataTable dataPengguna = queryExecutor(query, parameters);
            DataRow penggunaRow = dataPengguna.Rows[0];
            M_Pengguna pengguna = new M_Pengguna()
            {
                id = Convert.ToInt32(penggunaRow["id"]),
                username = penggunaRow["username"].ToString(),
                password = penggunaRow["password"].ToString(),
            };
            return pengguna;
        }
        
        public static void AddPengguna(M_Pengguna penggunabaru)
        {
            string query = $"INSERT INTO {table} (username,password) values (@username,@password)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = penggunabaru.username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = penggunabaru.password},
            };
            commandExecutor(query, parameters);
        }
        
        public static void UpdatePengguna(M_Pengguna penggunabaru)
        {
            string query = $"UPDATE {table} SET username = @username, password = @password WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = penggunabaru.username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = penggunabaru.password},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = penggunabaru.id},
            };
            commandExecutor(query, parameters);
        }
        
        public static void DeletePengguna(int id)
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
