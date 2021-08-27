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
            var query = new Queries();
            query.ManagerUnderlings();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
