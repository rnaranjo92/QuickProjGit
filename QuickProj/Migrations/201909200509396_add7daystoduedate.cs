namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add7daystoduedate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BookModels", "rentLength");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookModels", "rentLength", c => c.DateTime(nullable: false));
        }
    }
}
