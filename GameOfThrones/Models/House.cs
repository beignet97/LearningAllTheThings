using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOfThrones.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Words { get; set; }
        public int CastleId { get; set; }
        public virtual Castle Castle { get; set; }
    }
}