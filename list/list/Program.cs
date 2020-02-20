using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<course> courselist = new List<course>();
            courselist.Add(new course
            { cid = 1, Cname = "swa", subject = "c#",doj=DateTime.Now}
            );
            courselist.Add(new course
            { cid = 2, Cname = "manoj", subject = "c++",doj=DateTime.Parse("05-02-2020") }
            );

            foreach (course s in courselist)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",s.cid,s.Cname,s.doj,s.subject);
            }
            Console.WriteLine("hashlist");
            HashSet<hash> hashlist = new HashSet<hash>();
            hashlist.Add(new hash { cid = 30, Cname = "bublu", subject = "java", doj = DateTime.Now });
            hashlist.Add(new hash { cid = 31, Cname = "jaya", subject = "hadoop", doj = DateTime.Now });

            foreach(hash s in hashlist)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.cid, s.Cname, s.doj, s.subject);
            }
            Console.WriteLine("stack list");

            Stack<course> st = new Stack<course>();
            st.Push(new course
            { cid = 1, Cname = "stack1", subject = "c#", doj = DateTime.Now }
           );
            st.Push(new course
            { cid = 2, Cname = "stack2", subject = "c++", doj = DateTime.Parse("05-02-2020") }
            );
            foreach (course s in st)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.cid, s.Cname, s.doj, s.subject);
            }

            Console.WriteLine("queue");
            Queue<course> qu = new Queue<course>();
            qu.Enqueue(new course
            { cid = 1, Cname = "qu1", subject = "c#", doj = DateTime.Now }
           );
            qu.Enqueue(new course
            { cid = 2, Cname = "qu2", subject = "c++", doj = DateTime.Parse("05-02-2020") }
            );
            foreach (course s in qu)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.cid, s.Cname, s.doj, s.subject);
            }
            SortedDictionary<int, string> so = new SortedDictionary<int, string>();
            so.Add(123,"chennai");
            so.Add(124, "welcome");
            so.Add(125, "to");
            so.Add(126, "people");
            foreach (KeyValuePair<int, string> ct in so)
            {
                Console.WriteLine("{ 0}\t{1 }", ct.Key, ct.Value);
            }

            Console.ReadKey();
        }
    }
}
