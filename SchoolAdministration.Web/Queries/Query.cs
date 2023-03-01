using SchoolAdministration.Data.Models;
using SchoolAdministration.Domain;

namespace SchoolAdministration.Web.Queries
{
    public class Query
    {
        public Task<List<Student>> GetStudents(IStudentService studentService) =>
            studentService.GetStudents();
    }
}
