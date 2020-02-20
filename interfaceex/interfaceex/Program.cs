using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceex
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s = new cse();
            

            s.details("swathi", 567);
            s = new it();
            s.details("nagesh",5687);
            Console.ReadKey();
        }
    }
}
