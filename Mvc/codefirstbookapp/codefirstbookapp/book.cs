using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codefirstbookapp
{
    class book
    {
        [Key]
        public int bid { get; set; }
        public string  title { get; set; }
        public double price { get; set; }
        public virtual ICollection<details> Details { get; set; }

    }
}
