using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Data.Repositories;
using SchoolAdministration.Web.Graph;

var builder = WebApplication.CreateBuilder();

builder.Services
    .AddPooledDbContextFactory<ApplicationDbContext>(o =>
    {
        o.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
    })
    .AddTransient<ISchoolCommandRepository, SchoolCommandRepository>()
    .AddTransient<ISchoolQueryRepository, SchoolQueryRepository>();

builder.Services.AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>(DbContextKind.Pooled)
    .RegisterService<ISchoolCommandRepository>()
    .RegisterService<ISchoolQueryRepository>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();
