using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING_TASKS
{
    class reverse
    {
        public  void show(int[] arr)
        {
       
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array : ");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
           

        }
    }
}
