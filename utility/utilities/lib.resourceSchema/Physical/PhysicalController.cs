using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resourceSchema.Dal;

namespace resourceSchema.Physical
{
    public class PhysicalController
    {
        public static void Execute(string level, string command, string value)
        {
            switch (command.ToLower())
            {
                case "create.db":
                    PhysicalController.CreateDatabase(level, command, value);
                    break;
                default:
                    Console.WriteLine("Parameter error : Could not determine command.");
                    break;
            }
        }

        private static void CreateDatabase(string level, string command, string value)
        {
            Dal.Physical dal = new Dal.Physical();

            dal.BuildDatabase(value.ToUpper());

        }
    }
}
