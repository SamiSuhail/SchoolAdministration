using ConferencePlanner.GraphQL.Data;
using SchoolAdministration.Data.Models;
using SchoolAdministration.Web.Inputs;

namespace SchoolAdministration.Web.Mutations
{
    public class Mutation
    {
        public async Task<AddStudentPayload> AddStudentAsync(
            AddStudentInput input,
            [Service] ApplicationDbContext context)
        {
            var student = new Student
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
            };

            context.Students.Add(student);
            await context.SaveChangesAsync();

            return new AddStudentPayload(student);
        }
    }
}
