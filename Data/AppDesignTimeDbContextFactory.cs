using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data;

public class AppDesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        IConfiguration config = new ConfigurationBuilder()
             .AddUserSecrets<Data.AppDesignTimeDbContextFactory>()
             .Build();

        var opts = new DbContextOptionsBuilder<AppDbContext>();
        opts.UseSqlServer(config.GetConnectionString("DefaultConnection"));

        return new AppDbContext(opts.Options);
    }
}
