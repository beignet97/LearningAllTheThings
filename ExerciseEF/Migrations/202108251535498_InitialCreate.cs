namespace ExerciseEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LineManager_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.LineManager_EmployeeId)
                .Index(t => t.LineManager_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "LineManager_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "LineManager_EmployeeId" });
            DropTable("dbo.Employees");
        }
    }
}
