using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expressions
{
    class Circle
    {
        private double radius;
        string st;
        public double caluclate(Func<double,double>mp)
        {
            return mp(radius);
        }
        public string changecase(Func<string, string> up)
        {
            return up(st);
        }
    }
}
