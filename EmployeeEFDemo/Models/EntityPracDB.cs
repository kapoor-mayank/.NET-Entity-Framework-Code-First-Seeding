using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEFDemo.Models
{
 
        internal class EntityPracDB : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=PractiseDB;Integrated Security=True;");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Seed();
            }
            public DbSet<Department> Department { get; set; }
            public DbSet<Employee> Employees { get; set; }
        }


    }

