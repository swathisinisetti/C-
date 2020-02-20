using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            department d = new department(2, "cse");
            Employee e = new Employee(2,"swathi","cheanni",d);
            e.show();
            d.showdepart();
            
            
            Console.ReadKey();
            
           
        }
    }
}
