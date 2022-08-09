using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MovieFinder.ConsoleOutDebug; // Debugging purposes
using System.Reflection; // Just for debugging purpose - looping over props
namespace MovieFinder.Data;

public class MovieFinderDbContext : DbContext
{

    private IConfiguration _config { get; set; }
    private string _connectionString { get; }

    public DbSet<User> Users { get; set; }

    public MovieFinderDbContext()
    {
        _config = new ConfigurationBuilder()
           .AddEnvironmentVariables()
           .Build();

        _connectionString = _config.GetConnectionString("LocalDbConnection");
    }

    public MovieFinderDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseSqlServer(_connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
        else
        {
            optionsBuilder
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
