using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
           
                division d = new division();
                d.div(25, 0);
                Console.ReadKey();

            
        }
    }
}
