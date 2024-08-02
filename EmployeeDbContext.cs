using Microsoft.EntityFrameworkCore;

namespace WeltecEveningBatch
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
