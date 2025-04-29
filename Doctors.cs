using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Model
{
    [Table("Doctors")]
    class Doctors
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string doctorCode { get; set; }

        [MaxLength(40)]
        public string doctorName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public DateTime DOB { get; set; }

        [MaxLength(40)]
        public string branch { get; set; }
    }
}
