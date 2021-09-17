using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOfThrones.Models
{
    public class House
    {
        public int HouseId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Words { get; set; }

        [Display(Name = "Castle")]
        public virtual Castle CastleId { get; set; }
    }
}