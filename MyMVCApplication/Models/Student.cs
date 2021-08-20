using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string StudentName { get; set; }
        [Range(10, 20)]
        public int Age { get; set; }
    }
}