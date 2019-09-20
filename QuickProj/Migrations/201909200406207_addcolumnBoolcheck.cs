namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnBoolcheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookModels", "isAddedToCart", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookModels", "isAddedToCart");
        }
    }
}
