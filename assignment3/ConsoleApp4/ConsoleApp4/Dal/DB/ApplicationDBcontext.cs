using ConsoleApp4.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Dal.DB
{
    public class ApplicationDBcontext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InStockDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
      
}

        public DbSet <Employee> employees { get; set; }

    
    public DbSet<department> departments { get; set; }

        public DbSet<project> projects { get; set; }
    }
}
