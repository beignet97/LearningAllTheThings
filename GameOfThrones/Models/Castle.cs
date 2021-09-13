using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

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
        public Castle CastleId { get; set; }
    }

    public class CastleContext : DbContext
    {
        public DbSet<Castle> Castles { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}