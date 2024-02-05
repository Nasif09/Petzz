namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "BranchID", "dbo.Branches");
            DropIndex("dbo.Bookings", new[] { "BranchID" });
            AddColumn("dbo.Rooms", "BranchID", c => c.Int(nullable: false));
            CreateIndex("dbo.Rooms", "BranchID");
            AddForeignKey("dbo.Rooms", "BranchID", "dbo.Branches", "BranchID", cascadeDelete: true);
            DropColumn("dbo.Bookings", "BranchID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "BranchID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rooms", "BranchID", "dbo.Branches");
            DropIndex("dbo.Rooms", new[] { "BranchID" });
            DropColumn("dbo.Rooms", "BranchID");
            CreateIndex("dbo.Bookings", "BranchID");
            AddForeignKey("dbo.Bookings", "BranchID", "dbo.Branches", "BranchID", cascadeDelete: true);
        }
    }
}
