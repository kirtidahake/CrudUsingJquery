namespace ServerClientValidations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class site2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        SiteId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        SiteName = c.String(),
                    })
                .PrimaryKey(t => t.SiteId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sites", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Sites", new[] { "EmployeeId" });
            DropTable("dbo.Sites");
        }
    }
}
