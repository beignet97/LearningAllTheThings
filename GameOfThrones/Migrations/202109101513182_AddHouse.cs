namespace GameOfThrones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHouse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Castles",
                c => new
                    {
                        CastleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CastleId);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        HouseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Region = c.String(),
                        Words = c.String(),
                        CastleId_CastleId = c.Int(),
                    })
                .PrimaryKey(t => t.HouseId)
                .ForeignKey("dbo.Castles", t => t.CastleId_CastleId)
                .Index(t => t.CastleId_CastleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "CastleId_CastleId", "dbo.Castles");
            DropIndex("dbo.Houses", new[] { "CastleId_CastleId" });
            DropTable("dbo.Houses");
            DropTable("dbo.Castles");
        }
    }
}
