namespace GameOfThrones.Migrations
{
    using GameOfThrones.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameOfThrones.Models.CastleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameOfThrones.Models.CastleContext context)
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
        }
    }
}
