namespace SchoolAdministration.Data.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
