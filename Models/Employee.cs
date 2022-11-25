using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? Phone { get; set; }
        public DateTime Birthday { get; set; }
        public static DateTime SetBirthdate
        {
            get
            {
                bool dataCorecta = false;
                DateTime dateTime;
                do
                {
                    Console.Write("Birthday(mm/dd/yyyy): ");
                    string? date = Console.ReadLine(); ;
                    if (DateTime.TryParse(date, out dateTime))
                    {
                        dataCorecta = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Format \"DateTime\" not corect, insert date again\"ex: 01/16/2000\"");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (dataCorecta == false);
                return dateTime;
            }
        }
        public Employee(int Id, string? Name, string? FirstName, string Phone, DateTime Birthday)
        {
            this.Id = Id;
            this.Name = Name;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.Birthday = Birthday;
        }
    }
}



       

 