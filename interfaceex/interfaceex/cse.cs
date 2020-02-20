using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceex
{
    class cse:Student
    {
        //string firstname;
        //string lastname;
        string name;

        int idno;
        

        public string Name {get { return name; }set { name = value;}}
        public int Idno { get { return idno; } set { idno = value; } }
       
        public void details(string Name,int Idno)
        {
            
            Console.WriteLine("cse student name:{0},idno{1}",Name,Idno);
        }

       
    }
}

