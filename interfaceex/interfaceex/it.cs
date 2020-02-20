using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceex
{
    class it:Student
    {
        string name;
        int id;
//string subject;
        public string Name { get { return name; } set { name = value; } }
        public int Id { get {return id ; } set { id=value; } }
      //  public string Subject { get { return subject; } set {subject=value;} }
        public void details(string name,int id)
        {
            Console.WriteLine("the it student name:{0} id:{1}",Name,Id);
        }

    }
}
