using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadclass
{
    class Program
    {
        static void Main(string[] args)
        { 
                // Creating and initializing threads 
                Thread a = new Thread(ExThread.thread1);
            Thread a1 = new Thread(ExThread.thread1);
                Thread b = new Thread(ExThread.thread2);
                a.Start();
            // a.Suspend();
            a.Join();
                b.Start();
            Console.ReadKey();
            }
        }
    }
    
