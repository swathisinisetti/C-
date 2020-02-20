using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cont
{
    class Program
    {
        static void Main(string[] args)
        {
            increment n = new increment();
            increment n2 = new increment();
            increment.count();
            n.sample();
            Console.ReadKey();
            
        }
    }
}
