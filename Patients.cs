using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Model
{
    [Table("Patients")]
    class Patients
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string patientCode { get; set; }

        [MaxLength(40)]
        public string patientName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public DateTime DOB { get; set; }

        public int age { get; set; }
    }
}
