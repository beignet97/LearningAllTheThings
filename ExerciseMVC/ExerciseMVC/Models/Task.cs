using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ExerciseMVC.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        [Display(Name = "Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Date created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TaskDate { get; set; }
        public Category TaskCategory { get; set; }
    }

    public enum Category
    {
        Chore,
        Finance,
        Planning,
        Miscellaneous
    }

    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}