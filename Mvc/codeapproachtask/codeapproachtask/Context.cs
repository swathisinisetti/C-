using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace codeapproachtask
{
    class Context:DbContext
    {
        public Context() : base("context") { }
        public DbSet<customer> customers { get; set; }
       public DbSet<product> products{ get; set; }
        public DbSet<purchase> purchases { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
