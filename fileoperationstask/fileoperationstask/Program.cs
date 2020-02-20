using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileoperationstask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:task.txt";
            Console.WriteLine("!!CreateFile is allowed to enter only once.Incase You want to Write Delete File!!!!!!!\n");
            Fileop rw = new Fileop();
            int op;
            do
            {
                Console.WriteLine("\n1.CreateFile\t2.Display\t3.AddtoFile\t4.Delete\t5.Quit\n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: rw.write(path); break;
                    case 2: rw.read(path); break;
                    case 3: rw.append(path); break;
                    case 4: rw.delete(path); break;

                }
            } while (op <= 4);
            Console.ReadKey();
        }
    }
}
