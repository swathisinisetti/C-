using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_type
{
    class Program
    {

        static void Main(string[] args)
        {

            // Action<int, int> multiply = (x, y) => Console.Write("{0}", x * y);
            // Console.WriteLine("mul is is{0} ", multiply(4, 5));
            // Func<int, int, double> ad = (x, y) => x + y;
            // Console.WriteLine("add num is{0} ",ad(4,5));
            List<student> lst = new List<student>
            {
                new student{id=66,stdname="swathi",course="c#" },
                new student{id=12,stdname="man",course="vb" },
                new student{id=33,stdname="nag",course="java" },
                new student{id=46,stdname="jay",course="database" }

            };


            foreach (student s in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s.id, s.stdname, s.course);
            }
            Console.Read();
            lst.Sort((a, b) => a.id.CompareTo(b.id));
            Console.WriteLine("after sorting emloyee details are :");
            foreach (student s in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s.id, s.stdname, s.course);
            }
            Console.ReadKey();
        }
            
               
            


            //Predicate<student> fst = x => x.id == 1;
            // var st = lst.Find(fst);
            // Console.WriteLine("{0}\t {1}\t {2}",st.id,st.stdname,st.course);*/
          
           // Action<int, int> Add = (a, b) => Console.WriteLine();

        
    }
}
