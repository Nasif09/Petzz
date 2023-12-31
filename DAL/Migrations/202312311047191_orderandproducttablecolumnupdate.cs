namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderandproducttablecolumnupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Status_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_Id");
            CreateIndex("dbo.Orders", "Status_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "Status_Id", "dbo.Order_status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Status_Id", "dbo.Order_status");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "Status_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropColumn("dbo.Orders", "Status_Id");
            DropColumn("dbo.Products", "Category_Id");
        }
    }
}
