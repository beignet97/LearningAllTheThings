using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Alive { get; set; }
        public House HouseId { get; set; }
    }
}