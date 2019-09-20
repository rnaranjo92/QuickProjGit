namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makelibcardnullablev2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "libraryCardNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "libraryCardNumber", c => c.Int(nullable: false));
        }
    }
}
