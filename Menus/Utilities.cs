using WorkersApp.Models;

namespace WorkersApp.Menus
{
    public class Utilities
    {
        public static void CreateEmployee(List<Employee> employees)
        {
            Console.WriteLine("\n\n\t\tCreating an employee\t\n");
            Console.WriteLine($"\n\tSelect the type of employee desired! \n" +
                "1: Director\n" +
                "2: Engineer\n" +
                "3: Driver\n" +
                "4: Worker\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Select an action: ");
            Console.ForegroundColor = ConsoleColor.White;
            string? typeOfEMployee = Console.ReadLine();
            if (typeOfEMployee!="1"&& typeOfEMployee!="2"
                && typeOfEMployee!= "3"&&typeOfEMployee!="4")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Invalid selection: ");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("\n..........Set data...........\n");
            Console.Write("Id: ");

            if (!Int32.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("That's not a number!");
                return;
            }
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("First Name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Phone number: ");
            string? phone = Console.ReadLine();
            DateTime birthday = Employee.SetBirthdate;
            Employee? emp = null;
                switch (typeOfEMployee)
                {
                    case "1":
                        emp = new Director (id, name, firstName, phone!, birthday);
                        break;
                    case "2":
                         emp = new Engineer(id, name, firstName, phone!, birthday);
                        break;
                    case "3":
                        emp = new Driver(id, name, firstName, phone!, birthday);
                        break;
                    case "4":
                        emp = new Worker(id, name, firstName, phone!, birthday);
                        break;
                }
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.ForegroundColor = ConsoleColor.Red;   
                    Console.WriteLine("\n\n\t\t\tWrong ID (the id: "+id+" is already used)\n\n\n");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
                employees.Add(emp!);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t Employee created!!!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ReadEmployeeDetails(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            int i = 0;
            while (i < employees.Count)
            {
                Console.WriteLine("\n\t Employee ID: " + employees[i].Id + "\n\t.....................\n\n" +
             "Name: " + employees[i].Name + "\nFirst Name: " + employees[i].FirstName + "\nPhone number: " + employees[i].Phone + "\nBirthday: " +
                employees[i].Birthday.ToShortDateString() + "\n");
                i++;
            }
        }
        public static void UpdateEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            try
            {
                Console.Write("Enter the worker's Id to update: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Employee employee in employees)
                {
                    if (employee.Id == id)
                    {
                        Console.WriteLine("Enter the updated ID: ");
                        if (Int32.TryParse(Console.ReadLine(), out int x))
                        {
                            employee.Id = x;
                        }
                        else
                        {
                            Console.WriteLine("That's not a number!");
                            return;
                        }
                        Console.WriteLine("Enter the updated name: ");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Enter the updated firstname: ");
                        employee.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter the updated phone: ");
                        employee.Phone = Console.ReadLine();
                        employee.Birthday = Employee.SetBirthdate;
                    }
                    else Console.WriteLine("Id doesen't exist");
                }
            }
            catch(FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong ID type");
                Console.WriteLine(fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID doesnt exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("Write the Id of the employee you want to delete:");
            //int deleteId = Convert.ToInt32(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out int deleteId))
            {
                Console.WriteLine("That's not a number!");
                return;
            }
            foreach (Employee emp in employees)
            {
                if (emp.Id == deleteId)
                {
                    employees.Remove(emp);
                    Console.WriteLine($"Employee whith ID: {deleteId} was deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Id not found");
                    return;
                }
                
            }
        }
    }
}
