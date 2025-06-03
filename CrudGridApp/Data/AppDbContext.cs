using Microsoft.EntityFrameworkCore;
using CrudGridApp.Models;

namespace CrudGridApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet for Employees table
        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
