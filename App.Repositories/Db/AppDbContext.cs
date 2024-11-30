using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace App.Repositories.Db;
public class AppDbContext : DbContext
{
    public DbSet<Product> products = default!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}