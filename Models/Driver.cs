namespace WorkersApp.Models
{
    internal class Driver : Employee
    {
        public Driver(int Id, string? Name, string? FirstName, string Phone,
            DateTime Birthday) : base(Id, Name, FirstName, Phone, Birthday)
        {
        }
    }
}
