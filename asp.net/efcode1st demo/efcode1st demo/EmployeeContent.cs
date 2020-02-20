using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace efcode1st_demo
{
    class EmployeeContent:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
