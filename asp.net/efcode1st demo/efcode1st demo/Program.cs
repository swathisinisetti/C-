using System;
using System.Linq;

namespace efcode1st_demo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose the option: ");
            Console.WriteLine("1.GetEmployee \t 2.show \t 3.search \t 4.delete \t 5.update ");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    GetEmployee();
                    break;
                case 2:
                    show();
                    break;
                case 3:
                    search();
                    break;
                case 4:
                    delete();
                    break;
                case 5:
                    update();
                    break;
                default :
                    Console.WriteLine( false);
                    break;

            }

        }
        public static void  GetEmployee()
        {
            EmployeeContent e = new EmployeeContent();
            Console.WriteLine("enter the employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter the employee designation:");
            string desg = Console.ReadLine();
            Console.WriteLine("enter the salary");
            double sal = double.Parse(Console.ReadLine());
            e.Employees.Add(new Employee { ename = name, designation = desg, salary = sal });
            
            e.SaveChanges();
        }
        public  static void  show()
        {
            EmployeeContent ee = new EmployeeContent();
            var employees = ee.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.eid, emp.ename, emp.designation, emp.salary);
            }

        }
        public static void search()
        {
            EmployeeContent con = new EmployeeContent();
            var name1 = Console.ReadLine();

            var details = con.Employees.Where(s => s.ename == name1);
            foreach (var d in details)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",d.eid,d.ename,d.designation,d.salary);
            }                 
                                     
           /* Console.WriteLine("enter a emolpoee to search");
            int id = int.Parse(Console.ReadLine());
                
            var emp1 = from e in con.Employees
                      where e.eid == id
                      select e;
            foreach(var res in emp1)
            {
                Console.WriteLine("{0} {1} {2} {3}",res.eid,res.ename,res.designation,res.salary);
            }*/
            con.SaveChanges();


            

        }
        public static void delete()
        {
            EmployeeContent con = new EmployeeContent();
            Console.WriteLine("enter a emolyoee to delete");
            int id = int.Parse(Console.ReadLine());
           
           
            var emp1 = from e in con.Employees
                       where e.eid == id
                       select e;
            con.Employees.RemoveRange(emp1);

            foreach (var res in emp1)
            {
                Console.WriteLine(" deleted data is/n {0} {1} {2} {3}", res.eid, res.ename, res.designation, res.salary);
            }
            con.SaveChanges();


        }
        public static void update()
        {
            EmployeeContent con = new EmployeeContent();
            Console.WriteLine("enter a emolyoee to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a emolyoee salaree");

            double sal = double.Parse(Console.ReadLine());
            var emp = con.Employees;
            var emp1 = from e in emp
                       where e.eid == id
                       select e;
            foreach (var e in emp1)
            {
                e.salary = sal; 
            }
            
            foreach (var res in emp1)
            {
                Console.WriteLine(" updated data is/n {0} {1} {2} {3}", res.eid, res.ename, res.designation, res.salary);
            }
            con.SaveChanges();


        }
    }
}
