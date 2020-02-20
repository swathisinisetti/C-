using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static EmployeDBEntities1 edb = new EmployeDBEntities1();

        static void Main(string[] args)
        {
            //Courses();
            employee1();
        }

        private static void employee1()
        {
            Console.WriteLine("enter employee id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter designation");
            string designation = Console.ReadLine();
            Console.WriteLine("enter salry");
            decimal sal = decimal.Parse(Console.ReadLine());
            var emp = new Employee1
            {
                eid = id,
                ename = name,
                desigination = designation,
                salary = sal
            };

            foreach (var e in edb.Employee1)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.eid, e.ename, e.desigination, e.salary);
            }
            edb.Employee1.Add(emp);
            edb.SaveChanges();
            Console.ReadKey();

        }
    }
}
