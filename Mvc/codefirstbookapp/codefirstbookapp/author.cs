using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codefirstbookapp
{
    class author
    {
        [Key]
        public int aid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public virtual ICollection<details> Details { get; set; }
    }
}
