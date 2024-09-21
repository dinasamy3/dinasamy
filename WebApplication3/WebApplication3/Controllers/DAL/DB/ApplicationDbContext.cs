using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers.DAL.Entities;

namespace WebApplication3.Controllers.DAL.DB
{
    public class ApplicationDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InStockDb3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
       
}
        public DbSet<Employee> Employees { get; set; }
    }
}
