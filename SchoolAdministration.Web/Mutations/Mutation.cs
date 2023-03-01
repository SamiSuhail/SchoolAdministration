using SchoolAdministration.Data.Models;
using SchoolAdministration.Domain;
using SchoolAdministration.Web.Inputs;

namespace SchoolAdministration.Web.Mutations
{
    public class Mutation
    {
        public async Task<AddClassPayload> AddClassAsync(
            AddClassInput input,
            ISchoolService schoolService)
        {
            var @class = new Class
            {
                Name = input.Name
            };

            await schoolService.AddClass(@class);

            return new AddClassPayload(@class);
        }

        public async Task<AddStudentPayload> AddStudentAsync(
            AddStudentInput input,
            ISchoolService schoolService)
        {
            var student = new Student
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
                ClassId = input.ClassId,
            };

            await schoolService.AddStudent(student);

            return new AddStudentPayload(student);
        }

        public async Task<AddTeacherPayload> AddTeacherAsync(
            AddTeacherInput input,
            ISchoolService schoolService)
        {
            var teacher = new Teacher
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                DateOfBirth = input.DateOfBirth,
                ClassId = input.ClassId,
            };

            await schoolService.AddTeacher(teacher);

            return new AddTeacherPayload(teacher);
        }

        public async Task<AddTestResultPayload> AddTestResultAsync(
            AddTestResultInput input,
            ISchoolService schoolService)
        {
            var testResult = new TestResult
            {
               ClassId = input.ClassId,
               StudentId = input.StudentId,
               Grade = input.Grade,
            };

            await schoolService.AddTestResult(testResult);

            return new AddTestResultPayload(testResult);
        }
    }
}
