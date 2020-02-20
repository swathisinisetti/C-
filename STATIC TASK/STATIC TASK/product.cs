using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_TASK
{
    class product
    {
        string productname;
        int quantity;
        double price;
        static double totalamount=0;
       public string Productname { get { return productname; } set {productname=value; } }
        public double Price { get { return price; } set { price=value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double Saleamont { get {return price*quantity;} }
        public double Totalamount { get { return totalamount += Saleamont;} }

    }
}
