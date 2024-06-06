using Microsoft.EntityFrameworkCore;
using MyApp.Database;

namespace MyApp.Common
{
    public static class MigrateDatabase
    {
        public static void CheckMigrateDatabase(ApplicationDbContext context)
        {
            try
            {
                // Check if there is any data in the database
                if (!context.Students.Any())
                {
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

    
}
