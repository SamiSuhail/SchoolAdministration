using SchoolAdministration.Data.Models;
using SchoolAdministration.Data.Repositories;

namespace SchoolAdministration.Web.Graph
{
    public class Query
    {
        public IQueryable<Class> GetClasses(ISchoolQueryRepository repository) => repository.GetClasses();

        public IQueryable<Student> GetStudents(ISchoolQueryRepository repository) => repository.GetStudents();

        public IQueryable<Teacher> GetTeachers(ISchoolQueryRepository repository) => repository.GetTeachers();

        public IQueryable<TestResult> GetTestResults(ISchoolQueryRepository repository) => repository.GetTestResults();
    }
}
