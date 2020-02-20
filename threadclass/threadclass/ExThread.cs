using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadclass
{
    class ExThread
    {
        public static void thread1()
        {
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(z);
                Thread.Sleep(200);
                
            }
        }

        // static method for thread b 
        public static void thread2()
        {
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine("this is{0}",z);
                Thread.Sleep(400);
            }
        }
    }
}
