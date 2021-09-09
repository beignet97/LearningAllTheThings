namespace ExerciseMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "TaskDate", c => c.DateTime(nullable: false, defaultValue: DateTime.UtcNow));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "TaskDate");
        }
    }
}
