using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList() {"swathi","anu","anju","prassu","rams","sravs" ,"chandhu"};
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("hema");
            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2,2);
            Console.WriteLine();
            Hashtable hs = new Hashtable();
            hs.Add("dhgg","5665");
            hs.Add("fog", "567");
            hs.Add("fire", "939");
            hs.Add("time", "364");
            hs.Add("pass", "4647");
            foreach (string k in hs.Keys)
            {
                Console.WriteLine(hs["time"]);
            }
            Console.WriteLine();
            foreach (string h in hs.Values)
            {
                Console.WriteLine(h);
            }

            Stack stk = new Stack();
            stk.Push("swathi");
            stk.Push("pro");
            stk.Push("players");
            stk.Push("welcome");
            foreach (string s in stk) {
                Console.WriteLine(s);
            }
            stk.Pop();
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("queue list");

            Queue q = new Queue();
            q.Enqueue(455);
            q.Enqueue(456);
            q.Enqueue(457);
            q.Enqueue(458);
            foreach (int s in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("after deleting the queue elemnt");
            q.Dequeue();
            foreach (int s in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("the sortedlist");
            SortedList slist = new SortedList();
            slist.Add(1,"zammer");
            slist.Add(2, "razeem");
            slist.Add(3, "dghdsh");
            slist.Add(4, "tutrj");
            foreach (string v in slist.Values)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("the keys in sortedlist");
            foreach (int k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("generics");
            List<string> ss = new List<string>();
            ss.Add("tduy");
            ss.Add("tdu");
            ss.Add("tduy");
            ss.Add("tduy");
            foreach (string itm in ss)
            {
                Console.WriteLine(itm);
            }
            ss.Insert(4,"swa");
            Console.WriteLine();
            foreach (string itm in ss)
            {
                Console.WriteLine(itm);
            }


            Console.ReadKey();

        }
    }
}
