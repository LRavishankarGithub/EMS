using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSProject.Models;

namespace EMSProject.Data
{
    public class EMSProjectContext : DbContext
    {
        public EMSProjectContext (DbContextOptions<EMSProjectContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:emsnew.database.windows.net,1433;Initial Catalog=EMSNew;Persist Security Info=False;User ID=AdminUser;Password=Admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<EMSProject.Models.Employee> Employee { get; set; }
    }
}
