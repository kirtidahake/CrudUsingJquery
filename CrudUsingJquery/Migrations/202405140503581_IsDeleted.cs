namespace CrudUsingJquery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "Book_BookId", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_BookId" });
            AddColumn("dbo.Books", "IsDeleted", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "AuthorId", c => c.String());
            AddColumn("dbo.Books", "Author_AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "Author_AuthorId");
            AddForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors", "AuthorId");
            DropColumn("dbo.Authors", "BookTitle");
            DropColumn("dbo.Authors", "Book_BookId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "Book_BookId", c => c.Int());
            AddColumn("dbo.Authors", "BookTitle", c => c.String());
            DropForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorId" });
            DropColumn("dbo.Books", "Author_AuthorId");
            DropColumn("dbo.Books", "AuthorId");
            DropColumn("dbo.Books", "IsDeleted");
            CreateIndex("dbo.Authors", "Book_BookId");
            AddForeignKey("dbo.Authors", "Book_BookId", "dbo.Books", "BookId");
        }
    }
}
