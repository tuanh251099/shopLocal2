using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Data.EF
{
    public class shopLocalDbContextFactory : IDesignTimeDbContextFactory<shopLocationDbContext>
    {
        public shopLocationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("shopLocalDatabase");
                
            var optionsBuilder = new DbContextOptionsBuilder<shopLocationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new shopLocationDbContext(optionsBuilder.Options);
        }
    }
}
