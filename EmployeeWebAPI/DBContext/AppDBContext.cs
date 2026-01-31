using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options) : base(options)
        {
        }

        public virtual DbSet<EmployeeAPI> EmployeeAPI { get; set; }

    }
}
