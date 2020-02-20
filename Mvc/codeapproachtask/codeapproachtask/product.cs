using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codeapproachtask
{
    class product
    {
        [Key]
        public int pid { get; set; }
        [MaxLength(200)]
        public string name { get; set; }
        [Required]
        public double price  { get; set; }
        
        public virtual ICollection<purchase> Purchases { get; set; }

    }
}
