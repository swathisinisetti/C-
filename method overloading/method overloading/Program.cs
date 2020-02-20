using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            caluclating cl = new caluclating();
            Console.WriteLine(cl.area(12));
            Console.WriteLine(cl.area(18,29));
            Console.WriteLine(cl.area(36.4));
            Console.WriteLine(cl.area(5.4564,4));
            Console.ReadKey();

        }
    }
}
