using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstbookapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //insert();
            show();
        }
        public static void insert()
        {
            context c = new context();
            var book = new List<book>
            {
                new book{title="vaka pream katha",price=654 },
                new book{title="the heaven",price=1000 },
               new book{title="love story",price=300},
               new book{title="50shades",price=800 },

            };
            book.ForEach(f=> c.books.Add(f));
            c.SaveChanges();
            var author = new List<author>
            {
                new author{name="swathi",address="vizag"},
                new author{name="manoj",address="vijaywada"},
                new author{name="jaya",address="rjm"},
                new author{name="nag",address="vishakhapatnam"}
            };
            author.ForEach(s=> c.authors.Add(s));
            c.SaveChanges();
            var details = new List<details>
            {
                new details{bid=1,aid=2},
                new details{bid=2,aid=3},
                new details{ bid=3,aid=1},
                new details{bid=4,aid=4 }
            };
            details.ForEach(s=>c.detailss.Add(s));
            c.SaveChanges();
        }
        public static void show()
        {
            context c = new context();
            var books = c.books;
            Console.WriteLine("customer details are:");
            foreach (var p in books)
            {
                Console.WriteLine("{0}\t {1}\t {2} ", p.bid, p.title, p.price);

            }
            var authors = c.authors;
            Console.WriteLine("product  details are:");
            foreach (var p in authors)
            {
                Console.WriteLine("{0}\t {1}\t {2} ", p.aid, p.name, p.address);

            }
            var details = c.detailss;
            Console.WriteLine("purchases details are:");
            Console.WriteLine("{0,-8}{1,-14}{2,-18}{3,-17}{4,-16}{5,-19}", "pid", "aid", "title", "price", "name", "address");
            foreach (var p in details)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-18}{3,-17}{4,-16}{5,-19}", p.bid, p.aid, p.Book.title, p.Book.price, p.Author.name, p.Author.address);

            }
        }
    }
}
