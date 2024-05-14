namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsDeleted");
        }
    }
}
