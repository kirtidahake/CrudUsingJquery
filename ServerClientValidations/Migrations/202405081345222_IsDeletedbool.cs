namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedbool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "IsDeleted", c => c.Int(nullable: false));
        }
    }
}
