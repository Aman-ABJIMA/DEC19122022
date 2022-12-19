using Microsoft.EntityFrameworkCore;
using Storage_App.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_App.Data
{
    public class StorageAppDbContext :DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Organization> Organizations=> Set<Organization>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }




    }
}
