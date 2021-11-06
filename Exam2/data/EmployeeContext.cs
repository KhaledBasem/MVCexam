using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
    public class EmployeeContext:DbContext
    {
        
        public DbSet<Employee> employees { get; set; }

        public DbSet<Country> countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(local); initial catalog=Exam2;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
