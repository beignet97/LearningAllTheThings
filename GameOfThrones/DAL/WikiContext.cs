using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameOfThrones.DAL
{
    public class WikiContext : DbContext
    {
        public DbSet<Castle> Castles { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}