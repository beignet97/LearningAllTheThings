namespace GameOfThrones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Castles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Alive = c.Boolean(nullable: false),
                        HouseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Region = c.String(),
                        Words = c.String(),
                        CastleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.CastleId, cascadeDelete: true)
                .Index(t => t.CastleId);

            Sql("INSERT INTO Characters (FirstName, LastName, Alive, HouseId) VALUES ('Jon', 'Snow', 1, 4)," +
                                                                                            "('Arya', 'Stark', 1, 4)," +
                                                                                            "('Sansa', 'Stark', 1, 4)," +
                                                                                            "('Eddard', 'Stark', 0, 4)," +
                                                                                            "('Bran', 'Stark', 1, 4)," +
                                                                                            "('Robb', 'Stark', 0, 4)," +
                                                                                            "('Catelyn', 'Stark', 0, 4)," +
                                                                                            "('Robin', 'Arryn', 1, 1)," +
                                                                                            "('Lysa', 'Arryn', 0, 1)," +
                                                                                            "('Theon', 'Greyjoy', 1, 2)," +
                                                                                            "('Yara', 'Greyjoy', 1, 2)," +
                                                                                            "('Balon', 'Greyjoy', 0, 2)," +
                                                                                            "('Cersei', 'Lannister', 1, 3)," +
                                                                                            "('Tyrion', 'Lannister', 1, 3)," +
                                                                                            "('Jamie', 'Lannister', 1, 3)," +
                                                                                            "('Tywin', 'Lannister', 0, 3)," +
                                                                                            "('Joffrey', 'Lannister', 0, 3)," +
                                                                                            "('Tommen', 'Lannister', 0, 3)," +
                                                                                            "('Daenerys', 'Targaryen', 1, 5)," +
                                                                                            "('Rhaegar', 'Targaryen', 0, 5)," +
                                                                                            "('Walder', 'Frey', 0, 6)," +
                                                                                            "('Walda', 'Frey', 0, 6);");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "CastleId", "dbo.Castles");
            DropIndex("dbo.Houses", new[] { "CastleId" });
            DropTable("dbo.Houses");
            DropTable("dbo.Characters");
            DropTable("dbo.Castles");
        }
    }
}
