using Microsoft.EntityFrameworkCore;
using Sample.Management.Entities.EntityConfiguration;
using Sample.Management.EntityConfiguration;

namespace Sample.Management.DatabaseContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }
    }
}
