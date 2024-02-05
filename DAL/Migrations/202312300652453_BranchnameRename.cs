namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchnameRename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "Branchname", c => c.String());
            DropColumn("dbo.Branches", "Brancename");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Branches", "Brancename", c => c.String());
            DropColumn("dbo.Branches", "Branchname");
        }
    }
}
