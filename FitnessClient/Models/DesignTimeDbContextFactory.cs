using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FitnessClient.Models
{
  public class FitnessClientContextFactory : IDesignTimeDbContextFactory<FitnessClientContext>
  {

    FitnessClientContext IDesignTimeDbContextFactory<FitnessClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<FitnessClientContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new FitnessClientContext(builder.Options);
    }
  }
}