using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace delegatetask
{
    public delegate string del(int a);
    public static event del handler;
    class Program
    {
        static void Main(string[] args)
        {
            handler = new del(area);
            int a = int.Parse(Console.ReadLine());
            del d = new del(area);
            Console.WriteLine(d(a));
              }
        static string area(int x)
        {
            int c = x * x;
            return string.Format("area is:{0}", c);
        }
    }
}
