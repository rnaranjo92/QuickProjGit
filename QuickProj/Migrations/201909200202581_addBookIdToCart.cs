namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookIdToCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "BookId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "BookId");
        }
    }
}
