using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace efcode1st_demo
{
    class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public string designation { get; set; }
        public double salary { get; set; }
    }
}
