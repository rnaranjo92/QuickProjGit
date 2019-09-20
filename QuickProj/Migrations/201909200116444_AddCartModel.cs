namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        IsCheckedout = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BookModels", "Cart_Id", c => c.Int());
            CreateIndex("dbo.BookModels", "Cart_Id");
            AddForeignKey("dbo.BookModels", "Cart_Id", "dbo.Carts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookModels", "Cart_Id", "dbo.Carts");
            DropIndex("dbo.BookModels", new[] { "Cart_Id" });
            DropColumn("dbo.BookModels", "Cart_Id");
            DropTable("dbo.Carts");
        }
    }
}
