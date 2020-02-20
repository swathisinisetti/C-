using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class child:parent  /// multilevel inheritance
    {
        public virtual void show()
        {
            Console.WriteLine("this is child class");
        }
        new public void showvehicle()
        {
            Console.WriteLine("the new function which again rebuilded using new key word");
        }
    }
}
