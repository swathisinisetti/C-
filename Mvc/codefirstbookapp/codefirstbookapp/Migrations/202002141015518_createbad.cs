namespace codefirstbookapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createbad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.author",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.aid);
            
            CreateTable(
                "dbo.details",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        bid = c.Int(nullable: false),
                        aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.author", t => t.aid, cascadeDelete: true)
                .ForeignKey("dbo.book", t => t.bid, cascadeDelete: true)
                .Index(t => t.bid)
                .Index(t => t.aid);
            
            CreateTable(
                "dbo.book",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.details", "bid", "dbo.book");
            DropForeignKey("dbo.details", "aid", "dbo.author");
            DropIndex("dbo.details", new[] { "aid" });
            DropIndex("dbo.details", new[] { "bid" });
            DropTable("dbo.book");
            DropTable("dbo.details");
            DropTable("dbo.author");
        }
    }
}
