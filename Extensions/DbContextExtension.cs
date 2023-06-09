using NetCoreGraphQlLearn.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreGraphQlLearn.Extensions
{
    public static class DbContextExtension
    {
        public static void AddFakeDataToDb(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDb>();
            dbContext.Database.MigrateAsync().GetAwaiter().GetResult();
        }
    }
}
