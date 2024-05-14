namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredannotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Departments", "DName", c => c.String());
        }
    }
}
