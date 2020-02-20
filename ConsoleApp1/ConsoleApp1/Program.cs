using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);
            stb.Append(23434);//we can append anything to string
            Console.WriteLine("appended long values{0}",stb);
            int i = stb.Capacity;
            Console.WriteLine("intiatate capacity of stringbuilder {0}",i);
            stb.Insert(6,"world");
            Console.WriteLine("insert at 6 is {0}",stb);
            stb.Remove(7,3);// first is index and 3 is length 
            Console.WriteLine("after re,moving {0}",stb);
            stb.Replace("lo","arious");// lo word is replaced with word arious
            Console.WriteLine("after replacing the string {0}",stb);
            stb.Clear();// it delete all the string what we assigned upto now
            Console.WriteLine("after clear {0}",stb);
        }
    }
}
