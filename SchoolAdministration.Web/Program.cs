using ConferencePlanner.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using SchoolAdministration.Web.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<ApplicationDbContext>(o =>
    {
        o.UseSqlServer(builder.Configuration.GetConnectionString("Database"), 
            a => a.MigrationsAssembly("SchoolAdministration.Web"));
    })
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();
