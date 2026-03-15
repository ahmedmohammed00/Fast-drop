using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleApp1.Data
{
    public class DmsDbContextFactory : IDesignTimeDbContextFactory<DmsDbContext>
    {
        public DmsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DmsDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=dms_db;Trusted_Connection=True;TrustServerCertificate=True");

            return new DmsDbContext(optionsBuilder.Options);
        }
    }
}