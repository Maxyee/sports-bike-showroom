using Microsoft.EntityFrameworkCore;
using SportsBike.Models;

namespace SportsBike.Database
{
    public class MotorcycleDbContext : DbContext
    {
        public MotorcycleDbContext(DbContextOptions<MotorcycleDbContext> options): base(options)
        {

        }

        public DbSet<Motorcycle> motorcycles { get; set; }
    }
}
