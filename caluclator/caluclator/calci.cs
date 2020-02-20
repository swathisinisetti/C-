using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caluclator
{
    class calci
    {
        int a, b;
        //public  void add() { }
        public int add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int diff(int a,int b)
        {
            return a - b;
           
        }
        public int mul(int a,int b)
        {
            int c = a * b;
            return c;
        }
        public int div(int a, int b)
        {
            return  a / b;
             
        }
    }
}
