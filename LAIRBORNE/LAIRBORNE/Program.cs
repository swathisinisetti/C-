using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAIRBORNE
{
    class Program
    {
        static void Main(string[] args)
        {
            Lairborne l;
            l = new helicopter();
            l.fly();
            l = new aeroplaine();
            l.fly();
            Console.ReadKey();
        }
    }
}
