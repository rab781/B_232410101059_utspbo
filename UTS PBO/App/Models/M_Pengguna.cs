using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NpgsqlTypes;


namespace UTS_PBO.App.Models
{
    internal class M_Pengguna
    {
        [Key] public int id { get; set; }
        [Required] public string username { get; set; }
        [Required] public string password { get; set; }
    }
}
