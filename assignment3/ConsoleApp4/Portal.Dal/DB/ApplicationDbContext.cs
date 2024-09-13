using Microsoft.EntityFrameworkCore;
using Portal.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Dal.DB
{
    public class ApplicationDbContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
       
}
        public DbSet<Test>test { get; set; }
        
    }
}
