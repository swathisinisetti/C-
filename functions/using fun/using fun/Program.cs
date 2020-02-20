using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string ename;
            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("enter ur age");
            x = int.Parse(Console.ReadLine());
            //Program program = new Program();
            Program.Greeting(x,ename);
            Console.WriteLine("congrats Mr/Ms {0} on your {1}  birthday", ename, x);
        }
        static string Greeting(int x,string ename)
        {
            return string.Format(ename,x);
            Console.ReadKey();
        }
    }
}
