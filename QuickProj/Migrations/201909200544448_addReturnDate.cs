namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReturnDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BorrowedBooksByUsers", "ReturnDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BorrowedBooksByUsers", "ReturnDate");
        }
    }
}
