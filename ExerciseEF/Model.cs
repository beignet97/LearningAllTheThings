using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace ExerciseEF
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Employee LineManager { get; set; }
    }
}
