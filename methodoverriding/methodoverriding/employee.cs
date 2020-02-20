using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    class employee
    {
        int id;
        string name;
        double salary;
        public int Id { get; set; }
        public string Name { get; set; }
        //public double Salary { get; set; }
        public virtual string empsalary( double salary)
        {
            return  salary.ToString();
        }
    }
}
