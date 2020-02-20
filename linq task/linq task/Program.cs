using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10] { 5, 10, 4, 17, 15, 11, 23, 27, 29, 1 };
            var query = from n in num
                        where n%2 is 0
                       
                select n;
            foreach (var s in query)
            {
                Console.WriteLine(s);
            }

        }
    }
}
