using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codefirstbookapp
{
    class details
    {
        [Key]
        public int id { get; set; }
        public int bid { get; set; }
        public int aid { get; set; }
        public virtual book Book { get; set; }
        public virtual author Author { get; set; }
    }
}
