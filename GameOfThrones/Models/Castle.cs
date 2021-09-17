using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GameOfThrones.Models
{
    public class Castle
    {
        public int CastleId { get; set; }
        public string Name { get; set; }
    }

    public class House
    {
        public int HouseId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Words { get; set; }

        [Display(Name = "Castle")]
        public virtual Castle CastleId { get; set; }
    }

    public class Character
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Alive { get; set; }
        public House HouseId { get; set; }
    }

    public class CastleContext : DbContext
    {
        public DbSet<Castle> Castles { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}