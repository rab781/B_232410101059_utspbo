using System;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;

namespace UTS_PBO.App.Models
{
    internal class M_Admin
    {
        [Key]public int id { get; set; }
        [Required] public string username { get; set; }
        [Required] public string password { get; set; }
    }
}
