using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class subchild:child  //multilevel inheritance
    {
        public void showchild()
        {
            Console.WriteLine("the child function");
        }
        public override void show() // overriding the method from the child class using override keyword
        {
            //base.show();
            Console.WriteLine("the override method in subchild from child class");
        }
    }
}
