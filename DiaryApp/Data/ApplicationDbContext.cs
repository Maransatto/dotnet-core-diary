using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        // Four steps to add a table
        // 1. Create a Model Class
        // 2. Add a DB Set
        // 3. add-migration AddDiaryEntryTable
        // 3.1 for vs code: 
        //          dotnet ef migrations add AddDiaryEntryTable // create the migration
        //          dotnet tool install --global dotnet-ef
        // 4. update-database
        //          dotnet ef database update
    }
}