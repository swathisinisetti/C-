using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codeapproachtask
{
    class purchase
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime orderdate { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
        public virtual customer Customer { get; set; }
        public virtual product Product { get; set; }


    }
}
