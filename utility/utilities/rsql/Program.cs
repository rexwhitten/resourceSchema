using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resourceSchema;
using resourceSchema.Logical;
using resourceSchema.Physical;

namespace rsql
{
    class Program
    {
        static void Main(string[] args)
        {
            string level = "sql";
            string command = "create.db";
            string value = "test";

            if (args.Count() >= 3)
            {
                level = args[0];
                command = args[1];
                value = args[2];
            }

            switch (level .ToLower())
            {
                case "meta":
                    LogicalController.Execute(level, command, value);
                    break;
                case "sql" :
                    PhysicalController.Execute(level, command, value);
                    break;
                default:
                    Console.WriteLine("Parameter Error could not evaluate level.");
                    break;
            }

        }
    }
}
