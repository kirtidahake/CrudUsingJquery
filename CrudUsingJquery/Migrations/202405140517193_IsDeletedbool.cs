namespace CrudUsingJquery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedbool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "IsDeleted", c => c.Int(nullable: false));
        }
    }
}
