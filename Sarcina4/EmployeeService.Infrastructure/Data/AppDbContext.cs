using Microsoft.EntityFrameworkCore;
using EmployeeService.Domain.Entity;

namespace EmployeeService.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<JobTitle> JobTitles => Set<JobTitle>();
    }
}
