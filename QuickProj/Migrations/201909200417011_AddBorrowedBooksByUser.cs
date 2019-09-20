namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBorrowedBooksByUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowedBooksByUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookModels", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowedBooksByUsers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.BorrowedBooksByUsers", "BookId", "dbo.BookModels");
            DropIndex("dbo.BorrowedBooksByUsers", new[] { "BookId" });
            DropIndex("dbo.BorrowedBooksByUsers", new[] { "UserId" });
            DropTable("dbo.BorrowedBooksByUsers");
        }
    }
}
