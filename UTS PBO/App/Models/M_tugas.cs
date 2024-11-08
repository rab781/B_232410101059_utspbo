using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Models
{
    internal class M_Tugas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string judul { get; set; }
        [Required]
        public string deskripsi { get; set; }
        [Required]
        public DateTime deadline { get; set; }
    }
}
