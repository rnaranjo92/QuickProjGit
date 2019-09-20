namespace QuickProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migrationV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        ISBN = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookModels");
        }
    }
}
