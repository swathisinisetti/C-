using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class caluclating
    {
        public string area(int side)
        {
            int ar = side * side;
            return string.Format("square area ={0}", ar);
        }
        public string area(int l, int b)
        {
            int ar = l * b;
            return string.Format("rectangle area ={0}", ar);
        }
        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("circle area ={0}", ar);
        }
        public string area(double b, int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("triangle area ={0}", ar);

        }
    }
}