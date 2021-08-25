using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    class Populate
    {
        public void Fill(EmployeeContext db)
        {
            var malcolm = new Employee { Name = "Malcolm Smith" };
            var mat = new Employee { Name = "Mat Barrow", LineManager = malcolm };
            var tom = new Employee { Name = "Tom Keble", LineManager = mat };
            var andy = new Employee { Name = "Andy Winter", LineManager = tom };
            var vasilia = new Employee { Name = "Vasilia Themis", LineManager = andy };
            var sean = new Employee { Name = "Sean Parker", LineManager = andy };

            db.Employees.Add(malcolm);
            db.Employees.Add(mat);
            db.Employees.Add(tom);
            db.Employees.Add(andy);
            db.Employees.Add(vasilia);
            db.Employees.Add(sean);
            db.SaveChanges();
        }
    }
}
