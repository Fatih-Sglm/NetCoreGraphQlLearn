using Microsoft.EntityFrameworkCore;
using NetCoreGraphQlLearn.Database;
using NetCoreGraphQlLearn.Extensions;
using NetCoreGraphQlLearn.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDb>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Mssql")));
builder.Services.AddGraphQLServer().AddQueryType<Queries>().AddProjections().AddFiltering().AddSorting();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.AddFakeDataToDb();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();   
app.MapGraphQL("/graphql");
app.Run();
