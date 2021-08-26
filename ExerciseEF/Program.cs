using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeContext())
            {
                Console.WriteLine("Roles");
                Console.WriteLine("---------------");

                foreach (var role in db.Roles)
                {
                    Console.WriteLine(role.Name);
                }

                Console.WriteLine();
                Console.WriteLine("Employees");
                Console.WriteLine("--------------");

                foreach (var employee in db.Employees)
                {
                    Console.WriteLine(employee.Name);
                    Console.WriteLine(employee.Job.Name);

                    if (employee.LineManager != null)
                    {
                        Console.WriteLine(employee.LineManager.Name);
                    }
                    
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
