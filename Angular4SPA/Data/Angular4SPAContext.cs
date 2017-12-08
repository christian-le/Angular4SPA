using Angular4SPA.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Angular4SPA.Data
{
    public class Angular4SPAContext : DbContext
    {
        public Angular4SPAContext(DbContextOptions<Angular4SPAContext> options) : base(options)
        {
        }

        public DbSet<TestData> TestData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestData>().ToTable("TestData");
        }
    }
}
