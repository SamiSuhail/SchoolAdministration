using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Inputs
{
    public record AddStudentInput(
        string FirstName,
        string LastName,
        DateOnly DateOfBirth
        );

    public class AddStudentPayload
    {
        public AddStudentPayload(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }
}
