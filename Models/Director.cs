using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    internal class Director : Employee
    {
        public Director(int Id, string? Name, string? FirstName, string Phone, 
            DateTime Birthday) : base(Id, Name, FirstName, Phone, Birthday)
        {
        }
    }
}
