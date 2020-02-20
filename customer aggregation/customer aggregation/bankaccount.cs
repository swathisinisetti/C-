using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_aggregation
{
    class bankaccount
    {
        public double accuntno { get; set; }
        public double balance { get; set; }
        public void show()
        {
            Console.WriteLine("accountno= {0}, balance{1}", accuntno, balance);
        }
         
        public virtual double simpleintrest(double rate,int time)
        {

            double si = (balance * time * rate) / 100;
            return si;
        }
    }
}
