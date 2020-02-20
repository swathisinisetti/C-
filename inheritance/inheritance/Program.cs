using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            child ch = new child();
            ch.showvehicle();
            ch.show();
            subchild sc = new subchild();
            sc.showchild();
            sc.showvehicle();
            sc.show();
            Console.ReadKey();
        }
    }
}
