using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    public class Class1
    {
        public int no1 { get; set; }
        public int no2 { get; set; }
        public string add()
        {
            return string.Format("sum is : {0}", no1 + no2);
        }
        public string sub()
        {
            return string.Format("sub is : {0}", no1 - no2);
        }
        public string mul()
        {
            return string.Format("mul is : {0}", no1 * no2);
        }
        public string div()
        {
            return string.Format("div is : {0}", no1 / no2);
        }
    }
}
