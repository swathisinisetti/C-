using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        public static double area(double b,double h)
        {
            return 0.5 * b * h;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter the breadth of the triangle:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the height of the triangle:");
            double h = double.Parse(Console.ReadLine());
            Func<double, double, double> a = area;
            Console.WriteLine(a(b,h));


        }
    }
}
