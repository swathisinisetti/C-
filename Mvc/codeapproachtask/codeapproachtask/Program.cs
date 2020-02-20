using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeapproachtask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Getcustomers();
            //display();
            Insertdata();
            show();
        }
        /*    public static List<product> getproduct()
            {
                Context c = new Context();
                product p = new product();
                List<product> list = new List<product>();
                Console.WriteLine("enter the product name :");
                p.name = Console.ReadLine();
                Console.WriteLine("enter the price :");
                double price = double.Parse(Console.ReadLine());
                p.price = price;
                list.Add(p);


                //c.products.Add(new product { name = name, price=price });
               // return c.products.ToList();
    c.SaveChanges();
                return list;
            }
            public static void Getcustomers()
            {
                Context e = new Context();
               customer c = new customer();


                Console.WriteLine("enter the customer name:");
                c.name = Console.ReadLine();
                Console.WriteLine("enter the quantity:");
                c.quantity = int.Parse(Console.ReadLine());
                c.products = getproduct();

                Console.WriteLine("product list");
                e.customers.Add(c);

                e.SaveChanges();

            }
            public static List<product> display()
            {
                Context c = new Context();
                var p = c.products;
                foreach (var emp in p)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.id,emp.name,emp.price);
                }

                return c.products.Include("customers").ToList();
            }*/
        public static void Insertdata()
        {
            Context c = new Context();
            var customers = new List<customer> {
            new customer { name = "swathi", quantity = 45 },
            new customer { name = "nani", quantity = 33 },
            new customer { name = "prabhas", quantity = 27 },
            new customer { name = "mahi", quantity = 56 },
            new customer { name = "nag", quantity = 28 },
            new customer { name = "ali", quantity = 5 },
            new customer { name = "sri", quantity = 4 },
        };
            customers.ForEach(s => c.customers.Add(s));
            c.SaveChanges();
            var products = new List<product>
            {
                new product{name="rice",price=547 },
                new product{name="choco",price=75 },
                new product{name="dal",price=77 },
                new product{name="soap",price=47 },
                new product{name="sweets",price=76 },
                new product{name="snacks",price=57 },
               new product{name="biscuits",price=47 },
              };
            products.ForEach(s => c.products.Add(s));
            c.SaveChanges();
            var purchase = new List<purchase>
            {
                new purchase{orderdate=Convert.ToDateTime("9-2-2020"),pid=1,cid=3},
                new purchase{orderdate=Convert.ToDateTime("2-3-2020"),pid=2,cid=4},
                new purchase{orderdate=Convert.ToDateTime("5-5-2020"),pid=3,cid=6},
                new purchase{orderdate=Convert.ToDateTime("9-5-2020"),pid=4,cid=2},
                new purchase{orderdate=Convert.ToDateTime("7-2-2020"),pid=5,cid=5},
                new purchase{orderdate=Convert.ToDateTime("8-3-2020"),pid=6,cid=7},
                new purchase{orderdate=Convert.ToDateTime("4-2-2020"),pid=7,cid=8},
            };
            purchase.ForEach(pr=>c.purchases.Add(pr));
            c.SaveChanges();
            
        }
        public static void show()
        {
            Context c = new Context();
            var cutomers = c.customers;
            Console.WriteLine("customer details are:");
            foreach (var p in cutomers)
            {
                Console.WriteLine("{0}\t {1}\t {2} ",p.cid,p.name,p.quantity);

            }
            var products = c.products;
            Console.WriteLine("product  details are:");
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t {1}\t {2} ", p.pid, p.name, p.price);

            }
            var purchases = c.purchases;
            Console.WriteLine("purchases details are:");
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}","purchid","orderdate","pid","name","price","custid","custname");
            foreach (var p in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", p.id,p.orderdate.ToShortDateString(),p.pid,p.Product.name,p.Product.price,p.Customer.cid,p.Customer.name,p.Customer.quantity);

            }
        }
      
    }
}
