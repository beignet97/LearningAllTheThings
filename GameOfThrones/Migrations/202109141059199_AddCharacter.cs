namespace GameOfThrones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Alive = c.Boolean(nullable: false),
                        HouseId_HouseId = c.Int(),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Houses", t => t.HouseId_HouseId)
                .Index(t => t.HouseId_HouseId);

            Sql("INSERT INTO Characters (FirstName, LastName, Alive, HouseId_HouseId) VALUES ('Jon', 'Snow', 1, 3)," +
                                                                                            "('Arya', 'Stark', 1, 3)," +
                                                                                            "('Sansa', 'Stark', 1, 3)," +
                                                                                            "('Eddard', 'Stark', 0, 3)," +
                                                                                            "('Bran', 'Stark', 1, 3)," +
                                                                                            "('Robb', 'Stark', 0, 3)," +
                                                                                            "('Catelyn', 'Stark', 0, 3)," +
                                                                                            "('Robin', 'Arryn', 1, 6)," +
                                                                                            "('Lysa', 'Arryn', 0, 6)," +
                                                                                            "('Theon', 'Greyjoy', 1, 1)," +
                                                                                            "('Yara', 'Greyjoy', 1, 1)," +
                                                                                            "('Balon', 'Greyjoy', 0, 1)," +
                                                                                            "('Cersei', 'Lannister', 1, 2)," +
                                                                                            "('Tyrion', 'Lannister', 1, 2)," +
                                                                                            "('Jamie', 'Lannister', 1, 2)," +
                                                                                            "('Tywin', 'Lannister', 0, 2)," +
                                                                                            "('Joffrey', 'Lannister', 0, 2)," +
                                                                                            "('Tommen', 'Lannister', 0, 2)," +
                                                                                            "('Daenerys', 'Targaryen', 1, 4)," +
                                                                                            "('Rhaegar', 'Targaryen', 0, 4)," +
                                                                                            "('Walder', 'Frey', 0, 5)," +
                                                                                            "('Walda', 'Frey', 0, 5);");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "HouseId_HouseId", "dbo.Houses");
            DropIndex("dbo.Characters", new[] { "HouseId_HouseId" });
            DropTable("dbo.Characters");
        }
    }
}
