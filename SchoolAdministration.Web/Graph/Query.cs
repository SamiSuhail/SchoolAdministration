using SchoolAdministration.Data.Models;
using SchoolAdministration.Data.Repositories;

namespace SchoolAdministration.Web.Graph
{
    public class Query
    {
        [UsePaging, UseProjection, UseFiltering, UseSorting]
        public IQueryable<Class> GetClasses(ISchoolQueryRepository repository) => repository.GetClasses();

        [UsePaging, UseProjection, UseFiltering, UseSorting]
        public IQueryable<Student> GetStudents(ISchoolQueryRepository repository) => repository.GetStudents();

        [UsePaging, UseProjection, UseFiltering, UseSorting]
        public IQueryable<Teacher> GetTeachers(ISchoolQueryRepository repository) => repository.GetTeachers();

        [UsePaging, UseProjection, UseFiltering, UseSorting]
        public IQueryable<TestResult> GetTestResults(ISchoolQueryRepository repository) => repository.GetTestResults();
    }
}
