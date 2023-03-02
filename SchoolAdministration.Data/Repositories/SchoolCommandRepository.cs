using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Data.Repositories
{
    public interface ISchoolCommandRepository
    {
        Task AddClass(Class @class);
        Task AddStudent(Student student);
        Task AddTeacher(Teacher teacher);
        Task AddTestResult(TestResult testResult);
    }

    public sealed class SchoolCommandRepository : ISchoolCommandRepository, IAsyncDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        public SchoolCommandRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            this._dbContext = dbContextFactory.CreateDbContext();
        }

        public async Task AddClass(Class @class)
        {
            _dbContext.Classes.Add(@class);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddTeacher(Teacher teacher)
        {
            _dbContext.Teachers.Add(teacher);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddTestResult(TestResult testResult)
        {
            _dbContext.TestResults.Add(testResult);
            await _dbContext.SaveChangesAsync();
        }

        public ValueTask DisposeAsync() => _dbContext.DisposeAsync();
    }
}
