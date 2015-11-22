using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;

namespace DemoAPI.Models
{
  public class CustomerContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var Path = PlatformServices.Default.Application.ApplicationBasePath;
      optionsBuilder.UseNpgsql("Host=localhost;Username=dotnet_test;Password=dotnet;Database=dotnet_test");
    }
  }
}
