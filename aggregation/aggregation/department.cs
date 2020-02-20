using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
   public  class department
    {
        int id;
        string Dname;
        public  department(int id, string Dname)
        {
           this.id = id;
            this.Dname = Dname;
        }
        public void showdepart()
        {
            Console.WriteLine("{0} \t {1}",id,Dname);
        }

    }
    
}
