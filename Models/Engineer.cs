namespace WorkersApp.Models
{
    public class Engineer : Employee
    {
        public Engineer(int Id, string? Name, string? FirstName, string Phone,
            DateTime Birthday) : base(Id, Name, FirstName, Phone, Birthday)
        {
        }
    }
}
