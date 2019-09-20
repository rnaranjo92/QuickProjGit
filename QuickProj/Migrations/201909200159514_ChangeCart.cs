namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookModels", "Cart_Id", "dbo.Carts");
            DropIndex("dbo.BookModels", new[] { "Cart_Id" });
            DropColumn("dbo.BookModels", "Cart_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookModels", "Cart_Id", c => c.Int());
            CreateIndex("dbo.BookModels", "Cart_Id");
            AddForeignKey("dbo.BookModels", "Cart_Id", "dbo.Carts", "Id");
        }
    }
}
