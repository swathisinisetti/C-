using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    class Manager:employee
    {
        public override string empsalary(double salary)
        {
            double incentive = 647868;
            double total = incentive + salary;
            return total.ToString();
        }
    }
}
