using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            p.Productname = "choco";
            p.Quantity = 2;
            p.Price = 55.3;
            product p1 = new product();
            p1.Productname = "snacks";
            p1.Quantity = 5;
            p1.Price = 50;
            Console.WriteLine(p1.Saleamont);
            Console.WriteLine(p.Totalamount);
            Console.WriteLine(p1.Totalamount);
            Console.ReadKey();

        }
    }
}
