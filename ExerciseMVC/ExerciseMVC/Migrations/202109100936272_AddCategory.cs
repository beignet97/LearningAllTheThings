namespace ExerciseMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "TaskCategory", c => c.Int(nullable: false, defaultValue: 3));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "TaskCategory");
        }
    }
}
