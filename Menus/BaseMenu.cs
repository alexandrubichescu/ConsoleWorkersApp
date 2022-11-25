using WorkersApp.Models;

namespace WorkersApp.Menus
{
    public class BaseMenu
    {
       public static void BaseMenuRun()
        {
            List<Employee> employees = new();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("********Aplicatie salariala********");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            string? userSelection;
            

            do
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Select an action");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1: Create an employee");
                Console.WriteLine("2: Read/View employees");
                Console.WriteLine("3: Update employee");
                Console.WriteLine("4: Delete employee");
                Console.WriteLine("0: Exit aplication");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Select an action: ");
                userSelection = Console.ReadLine();
               
                switch (userSelection)
                {
                    case "1":
                        Utilities.CreateEmployee(employees);
                        break;
                    case "2":
                        Utilities.ReadEmployeeDetails(employees);
                        break;
                    case "3":
                        Utilities.UpdateEmployee(employees);
                        break;
                    case "4":
                        Utilities.DeleteEmployee(employees);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Invalid selection! Try again.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
            }
            while (userSelection != "0");
            Console.WriteLine("Thank you for using \"WorkersApp\"");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
