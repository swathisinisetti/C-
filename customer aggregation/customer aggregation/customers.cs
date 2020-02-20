using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_aggregation
{
    class customers
    {
        public string Custid { get; set; }
        public string Cusname { get; set; }
        public string Address { get; set; }
        public bankaccount bk { get; set; }
        public fixedintrest fi { get; set; }
        public string show()
        {
            return string.Format("customerid: {0}, customername: {1} ,customeraddress:{2}",Custid,Cusname,Address);
        }
    }
}
