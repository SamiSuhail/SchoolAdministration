namespace SchoolAdministration.Web.Types
{
    public abstract class Person
    {
        public DateOnly DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
