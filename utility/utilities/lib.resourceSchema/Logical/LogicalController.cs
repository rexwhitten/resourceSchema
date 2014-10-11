using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resourceSchema.Bll;

namespace resourceSchema.Logical
{
    /// <summary>
    /// Controlls the logic schema operations
    /// </summary>
    public class LogicalController
    {

        public static void Execute(string level, string command, string value)
        {
            switch (command.ToLower())
            {
                case "object.create":
                    LogicalController.ObjectCreate(level, command, value);
                    break;
                case "object.rename":
                    LogicalController.ObjectRename(level, command, value);
                    break;
                case "attribute.create":
                    LogicalController.AttributeCreate(level, command, value);
                    break;
                case "relation.create":
                    LogicalController.RelationCreate(level, command, value);
                    break;
                case "object.list":
                    LogicalController.ObjectList(level, command, value);
                    break;
                case "attribute.list":
                    LogicalController.AttributeList(level, command, value);
                    break;
                case "relation.list":
                    LogicalController.RelationList(level, command, value);
                    break;
                default:
                    Console.WriteLine("Parameter error : Could not determine command.");
                    break;
            }
        }

        private static void ObjectRename(string level, string command, string value)
        {
            
        }

        private static void RelationList(string level, string command, string value)
        {
            var results = Relations.GetAll().OrderBy(r => r.Parent);

            Console.ForegroundColor = ConsoleColor.Cyan;

            if (value == "*")
            {
                foreach (var result in results.OrderBy(p => p.Parent))
                {
                    Console.WriteLine(String.Format("{0} -- {1}", result.Parent, result.Child));
                }
            }
            else
            {
                foreach (var result in results
                                            .Where(r => r.Parent.ToLower().StartsWith(value.ToLower()))
                )
                {
                    Console.WriteLine(String.Format("{0} -- {1}", result.Parent, result.Child));
                }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void AttributeList(string level, string command, string value)
        {
            var results = Attributes.GetAll().OrderBy(a => a.Objecttitle);
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (value.ToLower() == "*")
            {
                // Return all attributes
                foreach (var result in results)
                {
                    Console.WriteLine("{0}.{1} as {2}", result.Objecttitle, result.Name, result.Name);
                }
            }
            else
            {
                // Return all attributes
                foreach (var result in results.Where(a => a.Objecttitle.ToLower().StartsWith(value.ToLower().Replace(".",""))))
                {
                    Console.WriteLine("{0}.{1} as {2}", result.Objecttitle, result.Name, result.Datatype);
                }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void ObjectList(string level, string command, string value)
        {
            var results = Objects.GetAll();

            Console.ForegroundColor = ConsoleColor.Cyan;

            if (value == "*")
            {
                foreach (var result in results.OrderBy(p => p.Title))
                {
                    Console.WriteLine(String.Format("{0} [{2}:{1}]", result.Title, result.Path, result.Id));
                }
            }
            else
            {
                foreach (var result in results
                                            .Where(o => o.Title.ToLower().Contains(value))
                                            .OrderBy(p => p.Title)
                )
                {
                    Console.WriteLine(String.Format("{0} [{2}:{1}]", result.Title, result.Path, result.Id));
                }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void RelationCreate(string level, string command, string value)
        {
            
        }

        private static void AttributeCreate(string level, string command, string value)
        {
            
        }

        private static void ObjectCreate(string level, string command, string value)
        {
            
        }
    }
}
