using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student("swathi","sinisetti");
               // s.firstname = "swathi";
               // s.lastname = "sinisetii";
                
                s.Idno = 232;
                s.Course = "cse";
                s.Doj = DateTime.Now;
           
           
            Console.WriteLine(" {0}\n Id is {1}",s.Name,s.Idno);
            Console.WriteLine("course is {0}\n Doj is {1}", s.Course, s.Doj);
            Console.ReadKey();

        }
    }
}
