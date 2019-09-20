namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvariablesinbookmodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookModels", "rentLength", c => c.DateTime(nullable: false));
            AddColumn("dbo.BookModels", "PublicationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookModels", "PublicationDate");
            DropColumn("dbo.BookModels", "rentLength");
        }
    }
}
