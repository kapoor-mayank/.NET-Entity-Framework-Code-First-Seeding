using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEFDemo.Models
{
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public string? City { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
