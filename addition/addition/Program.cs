using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        public static int add(int a, int b)
        {
            int c= a + b;
            return c;
        }
        public static double mul(int x,int y)
        {
            double z = x * y;
            return z;
        }

        static void Main(string[] args)
        {
            int a, b, x, y;
            a = 10; b = 20;
            x = 20;y = 10;
            int c = add(a,b);
            Console.WriteLine("the addition of {0} & {1} is {2} ",a,b,c);
            double w = mul(x,y);
            Console.WriteLine("the multiplication of {0} & {1} is {2}",x,y,w);
            Console.ReadKey();
        }
    }
}
