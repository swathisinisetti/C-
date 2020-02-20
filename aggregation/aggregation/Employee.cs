using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Employee
    {
        int id;
        string name, address;
        public department d;
        public  Employee(int id, string name, string address,department dt)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            d = dt;
}
        public void show()
        {
            Console.WriteLine("{0} \t {1} \t {2}", id,name,address);
        }


    }
       
 }
