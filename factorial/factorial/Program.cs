using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        public static int fact(int n)
        {
            if (n == 1)
            
                return 1;
                else
                return n * fact(n - 1);
            
        }

        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int f = fact(n);
            Console.WriteLine("the factorial of {0} is {1}",n,f);
            Console.ReadKey();
        }
    }
}
