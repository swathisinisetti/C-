namespace efcode1st_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        eid = c.Int(nullable: false, identity: true),
                        ename = c.String(),
                        designation = c.String(),
                        salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
