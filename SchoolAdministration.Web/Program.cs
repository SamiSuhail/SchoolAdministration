using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Domain;
using SchoolAdministration.Web.Mutations;
using SchoolAdministration.Web.Queries;

var builder = WebApplication.CreateBuilder();

builder.Services
    .AddPooledDbContextFactory<ApplicationDbContext>(o =>
    {
        o.UseSqlServer(builder.Configuration.GetConnectionString("Database"),
            a => a.MigrationsAssembly("SchoolAdministration.Web"));
    })
    .AddTransient<ISchoolService, SchoolService>();

builder.Services.AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>(DbContextKind.Pooled)
    .RegisterService<ISchoolService>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();
