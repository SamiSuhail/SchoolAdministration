using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Inputs
{
    public record AddTeacherInput(
        string FirstName,
        string LastName,
        DateOnly DateOfBirth,
        int ClassId
    );

    public class AddTeacherPayload
    {
        public AddTeacherPayload(Teacher teacher)
        {
            Teacher = teacher;
        }

        public Teacher Teacher { get; }
    }
}
