namespace GameOfThrones.Migrations
{
    using GameOfThrones.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameOfThrones.DAL.WikiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameOfThrones.DAL.WikiContext context)
        {
            context.Castles.AddOrUpdate(i => i.Name,
                new Castle
                {
                    Id = 1,
                    Name = "The Eyrie"
                },

                new Castle
                {
                    Id = 2,
                    Name = "Pyke"
                },

                new Castle
                {
                    Id = 3,
                    Name = "Casterly Rock"
                },

                new Castle
                {
                    Id = 4,
                    Name = "Winterfell"
                },

                new Castle
                {
                    Id = 5,
                    Name = "The Twins"
                },

                new Castle
                {
                    Id = 6,
                    Name = "Dragonstone"
                }
            );

            context.Houses.AddOrUpdate(i => i.Name,
                new House
                {
                    Id = 1,
                    Name = "Arryn",
                    Region = "The Vale of Arryn",
                    Words = "As High as Honor",
                    CastleId = context.Castles.Find(1).Id
                },

                new House
                {
                    Id = 2,
                    Name = "Greyjoy",
                    Region = "Iron Islands",
                    Words = "What Is Dead May Never Die",
                    CastleId = context.Castles.Find(2).Id
                },

                new House
                {
                    Id = 3,
                    Name = "Lannister",
                    Region = "The Westerlands",
                    Words = "A Lannister Always Pays His Debts",
                    CastleId = context.Castles.Find(3).Id
                },

                new House
                {
                    Id = 4,
                    Name = "Stark",
                    Region = "The North",
                    Words = "Winter Is Coming",
                    CastleId = context.Castles.Find(4).Id
                },

                new House
                {
                    Id = 5,
                    Name = "Targaryen",
                    Region = "The Crownlands",
                    Words = "Fire and Blood",
                    CastleId = context.Castles.Find(6).Id
                },

                new House
                {
                    Id = 6,
                    Name = "Frey",
                    Region = "The Riverlands",
                    Words = "We Stand Together",
                    CastleId = context.Castles.Find(5).Id
                }
            );
        }
    }
}
