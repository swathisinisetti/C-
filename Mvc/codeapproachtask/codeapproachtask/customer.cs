using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace codeapproachtask
{
    class customer
    {
        [Key]
        public int cid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int quantity { get; set; }
        public virtual ICollection<purchase> Purchases { get; set; }

        //public List<product> products { get; set; }
    }
}
