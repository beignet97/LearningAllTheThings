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
                var populator = new Populate();
                populator.Fill(db);

                foreach (var employee in db.Employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
