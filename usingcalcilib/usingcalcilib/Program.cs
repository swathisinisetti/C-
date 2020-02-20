using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calci;

namespace usingcalcilib
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.no1 = 400;
            c.no2 = 500;
            Console.WriteLine(c.add());
            Console.WriteLine(c.sub());
            Console.WriteLine(c.mul());
            Console.WriteLine(c.div());
            Console.ReadKey();
        }
    }
}
