namespace MagazinZaDrehi_Dimitrin_8_Petar_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Size = c.String(),
                        Gender = c.String(),
                        ProductTypesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypesId, cascadeDelete: true)
                .Index(t => t.ProductTypesId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductTypesId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypesId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
