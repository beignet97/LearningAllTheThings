namespace ExerciseEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            AddColumn("dbo.Employees", "Job_RoleId", c => c.Int());
            CreateIndex("dbo.Employees", "Job_RoleId");
            AddForeignKey("dbo.Employees", "Job_RoleId", "dbo.Roles", "RoleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Job_RoleId", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "Job_RoleId" });
            DropColumn("dbo.Employees", "Job_RoleId");
            DropTable("dbo.Roles");
        }
    }
}
