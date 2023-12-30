namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Petzz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        UID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        BranchID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Branches", t => t.BranchID, cascadeDelete: true)
                .ForeignKey("dbo.Registrations", t => t.UID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.UID)
                .Index(t => t.RoomID)
                .Index(t => t.BranchID);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        Brancename = c.String(),
                        Location = c.String(),
                        UID = c.Int(),
                    })
                .PrimaryKey(t => t.BranchID)
                .ForeignKey("dbo.Registrations", t => t.UID)
                .Index(t => t.UID);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        UID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 8),
                        Password = c.String(nullable: false, maxLength: 6),
                        Email = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        Availability = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "UID", "dbo.Registrations");
            DropForeignKey("dbo.Bookings", "BranchID", "dbo.Branches");
            DropForeignKey("dbo.Branches", "UID", "dbo.Registrations");
            DropIndex("dbo.Branches", new[] { "UID" });
            DropIndex("dbo.Bookings", new[] { "BranchID" });
            DropIndex("dbo.Bookings", new[] { "RoomID" });
            DropIndex("dbo.Bookings", new[] { "UID" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Registrations");
            DropTable("dbo.Branches");
            DropTable("dbo.Bookings");
        }
    }
}
