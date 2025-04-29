using Hospital.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Context
{
    class DataContext:DbContext
    {
        public DbSet<Patients> patients { get; set; }
        public DbSet<Doctors> doctors { get; set; }
    }
}
