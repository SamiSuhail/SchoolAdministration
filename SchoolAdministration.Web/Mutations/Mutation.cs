using SchoolAdministration.Data.Models;
using SchoolAdministration.Domain;
using SchoolAdministration.Web.Inputs;

namespace SchoolAdministration.Web.Mutations
{
    public class Mutation
    {
        public async Task<AddStudentPayload> AddStudentAsync(
            AddStudentInput input,
            IStudentService studentService)
        {
            var student = new Student
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
            };

            await studentService.AddStudent(student);

            return new AddStudentPayload(student);
        }
    }
}
