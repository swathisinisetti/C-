namespace codeapproachtask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcustpro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.purchase",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        orderdate = c.DateTime(nullable: false),
                        cid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.customer", t => t.cid, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.pid, cascadeDelete: true)
                .Index(t => t.cid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 200),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.purchase", "pid", "dbo.product");
            DropForeignKey("dbo.purchase", "cid", "dbo.customer");
            DropIndex("dbo.purchase", new[] { "pid" });
            DropIndex("dbo.purchase", new[] { "cid" });
            DropTable("dbo.product");
            DropTable("dbo.purchase");
            DropTable("dbo.customer");
        }
    }
}
