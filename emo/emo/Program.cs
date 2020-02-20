using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emo
{
    class Program
    {
       
        public delegate void Mydel(string s);
        static void Main(string[] args)
        {
            Mydel del = a => Console.WriteLine(a);
            del("hello");
            Func<int, double, double> Calc = (x,y) => x * y;
            Console.WriteLine(Calc(12, 10.5));
        }
    }
}
