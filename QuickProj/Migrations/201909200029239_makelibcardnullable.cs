namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makelibcardnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "libraryCardNumber", c => c.Int(nullable: true));
        }

        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "libraryCardNumber", c => c.Int(nullable: false));

        }
    }
}
