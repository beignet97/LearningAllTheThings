using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExerciseMVC.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDate { get; set; }
    }

    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}