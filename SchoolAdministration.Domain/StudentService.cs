using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Domain
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task AddStudent(Student student);
    }

    public class StudentService : IStudentService, IAsyncDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            this._dbContext = dbContextFactory.CreateDbContext();
        }

        public Task<List<Student>> GetStudents()
        {
            return _dbContext.Students.ToListAsync();
        }

        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }

        public async Task AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
        }
    }
}
