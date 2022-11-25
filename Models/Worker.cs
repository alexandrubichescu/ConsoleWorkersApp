namespace WorkersApp.Models
{
    internal class Worker : Employee
    {
        public Worker(int Id, string? Name, string? FirstName, string Phone, 
            DateTime Birthday) : base(Id, Name, FirstName, Phone, Birthday)
        {
        }
    }
}
