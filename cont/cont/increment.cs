using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cont
{
    class increment
    {
        int no;
        static int cnt;
        public void sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no: {0}\n count{1}: {1}",no,cnt);
        }
        public static void count()
        {
            cnt++;
            Console.WriteLine("the count value is {0}");

        }

    }
}
