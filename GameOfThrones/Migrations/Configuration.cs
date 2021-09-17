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
                    Name = "The Eyrie"
                },

                new Castle
                {
                    Name = "Pyke"
                },

                new Castle
                {
                    Name = "Casterly Rock"
                },

                new Castle
                {
                    Name = "Winterfell"
                },

                new Castle
                {
                    Name = "The Twins"
                },

                new Castle
                {
                    Name = "Dragonstone"
                }
            );

            context.Houses.AddOrUpdate(i => i.Name,
                new House
                {
                    Name = "Arryn",
                    Region = "The Vale of Arryn",
                    Words = "As High as Honor",
                    CastleId = context.Castles.Find(1)
                },

                new House
                {
                    Name = "Greyjoy",
                    Region = "Iron Islands",
                    Words = "What Is Dead May Never Die",
                    CastleId = context.Castles.Find(2)
                },

                new House
                {
                    Name = "Lannister",
                    Region = "The Westerlands",
                    Words = "A Lannister Always Pays His Debts",
                    CastleId = context.Castles.Find(3)
                },

                new House
                {
                    Name = "Stark",
                    Region = "The North",
                    Words = "Winter Is Coming",
                    CastleId = context.Castles.Find(4)
                },

                new House
                {
                    Name = "Targaryen",
                    Region = "The Crownlands",
                    Words = "Fire and Blood",
                    CastleId = context.Castles.Find(6)
                },

                new House
                {
                    Name = "Frey",
                    Region = "The Riverlands",
                    Words = "We Stand Together",
                    CastleId = context.Castles.Find(5)
                }
            );
        }
    }
}
