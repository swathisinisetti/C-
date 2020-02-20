using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace codefirstbookapp
{
    class context:DbContext
    {
        public context() : base("context") { }
        public DbSet<book> books { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<details> detailss { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
}
