using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee
            {
                Id = 2,
                Name = "swathi",
               // Salary = 645867,
            };
            Console.WriteLine("empid {0}\n name:{1}",e.Id,e.Name);
            Console.WriteLine("salary is {0}",e.empsalary(24000));
            Manager m = new Manager { Id = 325, Name = "swathi" };
            Console.WriteLine("{0} \n{1} ",m.Id,m.Name);
            m.empsalary(20000);
            Console.WriteLine("salary is {0}", m.empsalary(24000));
            Console.ReadKey();

        }
    }
}
