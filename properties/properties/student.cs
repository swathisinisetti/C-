using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class student
    {
        string firstname;
        string lastname;
       
        int idno;
        string course;
        DateTime doj;
        public  student() { }
        public  student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public string Name {
            get { return string.Format("the name is {0} {1}", firstname, lastname); }
        }
       // public string Name {get { return name; }set { name = value;}}
        public int Idno { get { return idno; } set { idno = value;} }

        public string Course { get { return course; } set { course = value; } }

        public DateTime Doj { get { return doj; } set { doj = value; } }
    }
}
