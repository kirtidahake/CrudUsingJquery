namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "DepartmentId_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId_DepartmentId" });
            RenameColumn(table: "dbo.Employees", name: "DepartmentId_DepartmentId", newName: "DepartmentId");
            AlterColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            AlterColumn("dbo.Employees", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "DepartmentId", newName: "DepartmentId_DepartmentId");
            CreateIndex("dbo.Employees", "DepartmentId_DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId_DepartmentId", "dbo.Departments", "DepartmentId");
        }
    }
}
