using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Data
{
    public class DmsDbContext : DbContext
    {
        public DmsDbContext(DbContextOptions<DmsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Default connection string (can be overridden by dependency injection)
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=dms_db;Trusted_Connection=True;Integrated Security = True;TrustServerCertificate = True");
            }
        }

     
    }
}