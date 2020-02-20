using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
        
            customers cus = new customers
            {
                Custid = "hdfc657",
                Cusname = "swathi",
                Address = "vizag",
                bk=new bankaccount
                {
                    accuntno = 54637,
                    balance = 2000,
                }

            };

                
           
            Console.WriteLine(cus.show());
            Console.WriteLine(cus.bk.simpleintrest(9.5,2));
            customers cus1 = new customers
            {
                Custid = "sbi567",
                Cusname = "fgrey",
                Address = "vizag",
                fi = new fixedintrest { }
            } ;
            Console.WriteLine(cus1.fi.simpleintrest(8.5,3));
             Console.ReadKey();

        }
    }
}
