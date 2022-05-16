using Microsoft.EntityFrameworkCore;
using PresentConnectionAPI.Models;

namespace PresentConnectionAPI.Config
{
    internal sealed class RecordsDBContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        // Override configure method
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/RecordsDB.db");

        // Add example data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Record[] recordsToSeed = new Record[5];

            for (int i = 1; i <= 5; i++)
            {
                recordsToSeed[i-1] = new Record
                {
                    Id = i,
                    Title = $"Record {i}",
                    Body = $"This is the body of {i} record form the database made for present connection",
                };
            }

            modelBuilder.Entity<Record>().HasData(recordsToSeed);
        }
    }
}
