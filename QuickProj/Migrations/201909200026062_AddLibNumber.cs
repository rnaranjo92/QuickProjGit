namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLibNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "libraryCardNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "libraryCardNumber");
        }
    }
}
