namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumPages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookModels", "NumberOfPages", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookModels", "NumberOfPages");
        }
    }
}
