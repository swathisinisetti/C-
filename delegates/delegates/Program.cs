using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate string Mydel(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Mydel delg = new Mydel(add);
            Console.WriteLine(delg(67, 54));
            delg += new Mydel(subtract);
            Console.WriteLine(delg(12, 23));
            delg -= new Mydel(add);
            Console.WriteLine(delg(20, 50));
           
        }
        static string add(int a,int b)
        {
            int c = a + b;
            return string.Format("{0}+{1}={2}",a,b,c);
        }
        static string subtract(int a, int b)
        {
            int c = a - b;
            return string.Format("{0}-{1}={2}", a, b, c);
        }
        
    }
    }

