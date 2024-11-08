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
    internal class TugasContext : DataWrapper
    {
        private static string table = "tugas";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataTugas = queryExecutor(query);
            return dataTugas;
        }
     
        public static M_Tugas GetById(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            DataTable dataTugas = queryExecutor(query, parameters);
            DataRow tugasRow = dataTugas.Rows[0];
            M_Tugas tugas = new M_Tugas()
            {
                id = Convert.ToInt32(tugasRow["id"]),
                judul = tugasRow["judul"].ToString(),
                deskripsi = tugasRow["deskripsi"].ToString(),
                deadline = Convert.ToDateTime(tugasRow["deadline"]),
            };
            return tugas;
        }
        
        public static void AddTugas(M_Tugas tugasbaru)
        {
            string query = $"INSERT INTO {table} (judul,deskripsi,deadline) values (@judul,@deskripsi,@deadline)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul", NpgsqlDbType.Varchar){Value = tugasbaru.judul},
                new NpgsqlParameter("@deskripsi", NpgsqlDbType.Varchar){Value = tugasbaru.deskripsi},
                new NpgsqlParameter("@deadline", NpgsqlDbType.Date){Value = tugasbaru.deadline},
            };
            commandExecutor(query, parameters);
        }
       
        public static void UpdateTugas(M_Tugas tugasbaru)
        {
            string query = $"UPDATE {table} SET judul = @judul, deskripsi = @deskripsi, deadline = @deadline WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul", NpgsqlDbType.Varchar){Value = tugasbaru.judul},
                new NpgsqlParameter("@deskripsi", NpgsqlDbType.Varchar){Value = tugasbaru.deskripsi},
                new NpgsqlParameter("@deadline", NpgsqlDbType.Date){Value = tugasbaru.deadline},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = tugasbaru.id},
            };
            commandExecutor(query, parameters);
        }
        
        public static void DeleteTugas(int id)
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
