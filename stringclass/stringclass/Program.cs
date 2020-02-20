using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringclass
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "hello world";
            Console.WriteLine(data);
            string a = data.Insert(6,"my");
            // add "my" word in the 6th postion in the data string
            string bn = "you are so cute";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a,bn));
            // this function used to concat the 2 strings
            string up = data.ToUpper();
            //this function is used to change string into uppercase
            string lc = data.ToLower();
            // to change the string in lower case

            Console.WriteLine("substring{0}",bn.Substring(4,4));
            //first 4 is starting index of the string and 2nd 4 is length
            string[] names = new string[] {"swathi","mahi","nag","sarva" };
            foreach (string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",",names);
            // we use join to to connect the names array elements with "," symbol
            Console.WriteLine(allnames);
            string str1 = "welcome to the c#";
            string[] words = str1.Split();
            // it splits the sentence depends on the array index
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            string str = string.Copy(str1);
            // it copies the string to str variable from the str1
            Console.WriteLine(str);
            int i = str1.IndexOf("to");
            //it shows the postion of "to" in str1
            Console.WriteLine("index of is {0}",i);
            int l = str1.Length;
            //to show the length of the string 
            int nx=string.Compare("hello","world");
            // it compare the string what we passed in the function if they are equal it gives 0 else -1
            Console.WriteLine("comparision is {0}",nx);
            Console.ReadKey();
        }
    }
}
