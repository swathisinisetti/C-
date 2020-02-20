using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leapyear;

namespace leapyearlib
{
    class Program
    {
        static void Main(string[] args)
        {
            
            find f = new find();
            f.readdata();
            f.leap();
            Console.WriteLine();
        }
    }
}
