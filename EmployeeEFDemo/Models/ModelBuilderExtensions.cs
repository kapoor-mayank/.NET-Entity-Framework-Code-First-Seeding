using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEFDemo.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DeptName = "IT",
                    Id = 1,
                },
                new Department
                {
                    DeptName = "HR",
                    Id=2,
                },
                new Department
                {
                    DeptName = "MKT",
                    Id=3,
                },
                new Department
                {
                    DeptName = "ADMIN",
                    Id=4,
                });
        }
    }
}
