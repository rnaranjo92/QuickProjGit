namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Carts", "BookId");
            AddForeignKey("dbo.Carts", "BookId", "dbo.BookModels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "BookId", "dbo.BookModels");
            DropIndex("dbo.Carts", new[] { "BookId" });
        }
    }
}
