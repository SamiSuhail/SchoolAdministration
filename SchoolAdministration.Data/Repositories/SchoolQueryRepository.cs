using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Data.Repositories
{
    public interface ISchoolQueryRepository
    {
        IQueryable<Class> GetClasses();
        IQueryable<Student> GetStudents();
        IQueryable<Teacher> GetTeachers();
        IQueryable<TestResult> GetTestResults();
    }

    public sealed class SchoolQueryRepository : ISchoolQueryRepository, IAsyncDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        public SchoolQueryRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            this._dbContext = dbContextFactory.CreateDbContext();
        }

        public IQueryable<Class> GetClasses() => _dbContext.Classes;

        public IQueryable<Student> GetStudents() => _dbContext.Students;

        public IQueryable<Teacher> GetTeachers() => _dbContext.Teachers;

        public IQueryable<TestResult> GetTestResults() => _dbContext.TestResults;

        public ValueTask DisposeAsync() => _dbContext.DisposeAsync();
    }
}
