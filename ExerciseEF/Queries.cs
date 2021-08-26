using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    class Queries
    {
        public void EmployeesPerRole()
        {
            using (var db = new EmployeeContext())
            {
                foreach (var role in db.Roles)
                {
                    Console.WriteLine(role.Name);

                    var employees = db.Employees
                                    .Where(e => e.Job.Name == role.Name)
                                    .ToList()
                                    .Count();

                    Console.WriteLine(employees + " employees");
                    Console.WriteLine();
                }
            }
        }

        public void Managers()
        {
            using (var db = new EmployeeContext())
            {
                Console.WriteLine("The following employees are line managers:");

                foreach (var employee in db.Employees)
                {
                    if (db.Employees.Any(person => employee.EmployeeId == person.LineManager.EmployeeId))
                    {
                        Console.WriteLine(employee.Name);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
