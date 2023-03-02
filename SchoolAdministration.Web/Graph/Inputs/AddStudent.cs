using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Inputs
{
    public record AddStudentInput(
        string FirstName,
        string LastName,
        DateOnly DateOfBirth,
        int ClassId
    );

    public class AddStudentPayload
    {
        public AddStudentPayload(Student student)
        {
            this.Student = student;
        }

        public Student Student { get; }
    }
}
