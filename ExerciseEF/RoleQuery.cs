using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    class RoleQuery
    {
        static void Main(string[] args)
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

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
