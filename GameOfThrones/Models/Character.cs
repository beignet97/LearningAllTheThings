using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Alive { get; set; }
        public int HouseId { get; set; }
    }
}