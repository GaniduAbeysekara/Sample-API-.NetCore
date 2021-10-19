using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sample.Management.DatabaseContext;
using System;

namespace Sample.Management
{
    [UsedImplicitly]
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var mySqlConnectionStr = "server=localhost; port=3306; database=testDb; user=root; password=; Persist Security Info=False; Connect Timeout=300";

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)).Options;


            Console.WriteLine($"Using connection {mySqlConnectionStr}");
            return new AppDbContext(options);
        }
    }
}
