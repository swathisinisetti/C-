using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getnumbers);
          // tsd += new ThreadStart(getnumbers);
            Thread t = new Thread(tsd);
            t.Start();
            ThreadStart td = new ThreadStart(getnumbers);
            Thread tt = new Thread(td);
            tt.Start();
        }
        public static void getnumbers()
        {
            for (int i= 0;i< 10; i++)
            {
                Console.Write("{0}",i);
                Thread.Sleep(200);
                
            }
           }
        public async void show(string s)
        {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}
