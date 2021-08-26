using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    class Populate
    {
        public void FillEmployees(EmployeeContext db)
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

        public void FillRoles(EmployeeContext db)
        {
            var chair = new Role { Name = "Chairman" };
            var ceo = new Role { Name = "CEO" };
            var cto = new Role { Name = "CTO" };
            var hoe = new Role { Name = "Head of Engineering" };
            var sse = new Role { Name = "Senior Software Engineer" };
            var jse = new Role { Name = "Junior Software Engineer" };

            db.Roles.Add(chair);
            db.Roles.Add(ceo);
            db.Roles.Add(cto);
            db.Roles.Add(hoe);
            db.Roles.Add(sse);
            db.Roles.Add(jse);
            db.SaveChanges();
        }
    }
}
