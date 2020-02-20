using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caluclator
{
    class Program
    {
        static void Main(string[] args)
        {


            calci cc = new calci();
            Console.WriteLine(cc.add(2,2));
            Console.WriteLine(cc.diff(45,33));
            Console.WriteLine(cc.mul(2,4));
            Console.WriteLine(cc.div(66,10));
        }
    }
}
