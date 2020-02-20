using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lambda_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine("enter the radius of the circle:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(c.caluclate(r=>2*Math.PI*p));
            Console.WriteLine();
            Console.WriteLine(c.caluclate(r=>Math.PI*p*p));
            Console.WriteLine(c.caluclate(a=>p*p*p));
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(c.changecase(a=>s.ToUpper()));
            string t = "IN UPPER CASE";
            Console.WriteLine(c.changecase(x=>t.ToLower()));


        }
    }
}
