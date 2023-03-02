using SchoolAdministration.Data.Models;
using SchoolAdministration.Data.Repositories;
using SchoolAdministration.Web.Inputs;

namespace SchoolAdministration.Web.Graph
{
    public class Mutation
    {
        public async Task<AddClassPayload> AddClassAsync(
            AddClassInput input,
            ISchoolCommandRepository repository)
        {
            var @class = new Class
            {
                Name = input.Name
            };

            await repository.AddClass(@class);

            return new AddClassPayload(@class);
        }

        public async Task<AddStudentPayload> AddStudentAsync(
            AddStudentInput input,
            ISchoolCommandRepository repository)
        {
            var student = new Student
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
                ClassId = input.ClassId,
            };

            await repository.AddStudent(student);

            return new AddStudentPayload(student);
        }

        public async Task<AddTeacherPayload> AddTeacherAsync(
            AddTeacherInput input,
            ISchoolCommandRepository repository)
        {
            var teacher = new Teacher
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
                ClassId = input.ClassId,
            };

            await repository.AddTeacher(teacher);

            return new AddTeacherPayload(teacher);
        }

        public async Task<AddTestResultPayload> AddTestResultAsync(
            AddTestResultInput input,
            ISchoolCommandRepository repository)
        {
            var testResult = new TestResult
            {
                ClassId = input.ClassId,
                StudentId = input.StudentId,
                Grade = input.Grade,
            };

            await repository.AddTestResult(testResult);

            return new AddTestResultPayload(testResult);
        }
    }
}
