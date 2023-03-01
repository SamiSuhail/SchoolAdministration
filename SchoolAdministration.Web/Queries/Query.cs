using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Queries
{
    public class Query
    {
        public Class GetClass(string? name = null)
        {
            return new Class
            {
                Name = name ?? "New Class",
                Teacher = new Teacher
                {
                    FirstName = "Math",
                    LastName = "Teacher",
                    Subject = Subject.Math,
                    DateOfBirth = new(1990, 01, 13),
                    Students = new Student[]
                    {
                        new() { DateOfBirth = new(2006, 10, 28), FirstName = "Student1", LastName = "Student1"},
                        new() { DateOfBirth = new(2006, 11, 28), FirstName = "Student2", LastName = "Student2"},
                        new() { DateOfBirth = new(2006, 10, 24), FirstName = "Student3", LastName = "Student3"},
                    }
                },
                Tests = Array.Empty<Test>()
            };
        }
    }
}
