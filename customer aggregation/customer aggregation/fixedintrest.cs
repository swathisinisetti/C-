using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_aggregation
{
    class fixedintrest:bankaccount
    {
       // bankaccount v = new bankaccount();
        public override double simpleintrest(double rate,int time)
        {
            double si =(balance * time * rate) / 100;
            double newadd = si * 0.003;
            double fi = si + newadd;
            return fi;
        }
    }
}
