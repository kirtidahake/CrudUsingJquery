namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        DepartmentId_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId_DepartmentId)
                .Index(t => t.DepartmentId_DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId_DepartmentId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
